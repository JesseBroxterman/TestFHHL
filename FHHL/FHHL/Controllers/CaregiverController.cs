using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FHHL.BLL.Interfaces;
using FHHL.Data.DomainModels;
using Common.Web.Alerts;
using FHHL.Web.Models.Caregiver;
using Microsoft.AspNetCore.Mvc;
using FHHL.Web.Models;
using FHHL.Data.Extensions;

namespace FHHL.Web.Controllers
{
    public class CaregiverController : Controller
    {
        private readonly IReferralService _recordService;
        private readonly IOptionsService _optionsService;
        private readonly ICaregiverService _caregiverService;

        public CaregiverController(IReferralService recordService, IOptionsService optionsService, ICaregiverService caregiverService)
        {
            _recordService = recordService;
            _optionsService = optionsService;
            _caregiverService = caregiverService;
        }

        private string _userName
        {
            get
            {
                if (User.Claims.Where(c => c.Type == "name").Any())
                    return User.Claims.Where(c => c.Type == "name").First().Value;
                else
                    return User.Identity.Name ?? "Unknown";
            }
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model).WithDanger("Error", "There are errors on the form.");

            var caregiver = new Caregiver
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = _userName,
                DateOfBirth = model.DateOfBirth,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Foster = model.Foster,
                MomClass = model.MomClass,
                Spanish = model.Spanish,
                Zip = model.Zip
            };

            await _caregiverService.CreateCaregiver(caregiver, model.SelectedRaces);

            return RedirectToAction(nameof(Dashboard), "Caregiver", new { id = caregiver.Id }).WithSuccess("Success", $"{caregiver.FirstName} {caregiver.LastName} has been created.");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var caregiver = await _caregiverService.GetCaregiverByIdAsync(id);

            if (caregiver == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding caregiver.");

            var caregiverRaces = await _caregiverService.GetCaregiverRacesByCaregiverId(caregiver.Id);

            var vm = new EditViewModel
            {
                DateOfBirth = caregiver.DateOfBirth,
                FirstName = caregiver.FirstName,
                LastName = caregiver.LastName,
                Foster = caregiver.Foster,
                Id = caregiver.Id,
                MomClass = caregiver.MomClass,
                Spanish = caregiver.Spanish,
                Zip = caregiver.Zip,
                SelectedRaces = caregiverRaces.Select(r => r.RaceId).Distinct().ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model).WithDanger("Error", "There are errors on the form.");

            var caregiver = new Caregiver()
            {
                Id = model.Id,
                ChgDateTimeOffset = DateTimeOffset.Now,
                ChgUser = _userName,
                DateOfBirth = model.DateOfBirth,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Foster = model.Foster,
                MomClass = model.MomClass,
                Spanish = model.Spanish,
                Zip = model.Zip
            };

            await _caregiverService.EditCaregiver(caregiver, model.SelectedRaces);

            return RedirectToAction(nameof(Dashboard), "Caregiver", new { id = model.Id }).WithSuccess("Success", $"{caregiver.FirstName} {caregiver.LastName} has been updated.");
        }

        public async Task<IActionResult> Dashboard(int id)
        {
            var caregiver = await _caregiverService.GetCaregiverByIdAsync(id);

            if (caregiver == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding caregiver.");

            var vm = new DashboardViewModel
            {
                DateOfBirth = caregiver.DateOfBirth,
                FirstName = caregiver.FirstName,
                LastName = caregiver.LastName,
                Foster = caregiver.Foster,
                Id = caregiver.Id,
                MomClass = caregiver.MomClass,
                Spanish = caregiver.Spanish,
                Zip = caregiver.Zip,
                Referrals = await _recordService.GetReferralsByCaregiverIdAsync(caregiver.Id),
                Assignees = await _optionsService.GetAssigneesAsync(),
                AdultFlag = false,
                DelFlag = caregiver.DelFlag
            };

            DateTime now = DateTime.Today;
            if (caregiver.DateOfBirth.HasValue)
            {
                int age = now.Year - caregiver.DateOfBirth.Value.Year;
                if (now < caregiver.DateOfBirth.Value.AddYears(age))
                    age--;

                if (age >= 19)
                    vm.AdultFlag = true;
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> CheckCaregiver(CheckCaregiverViewModel vm)
        {
            if (!ModelState.IsValid)
                return Json(new { success = false, message = "There are errors on the form" });

            var isDuplicate = await _caregiverService.CheckForCaregiverByNameAndDoB(vm.FirstName, vm.LastName, vm.DateOfBirth);
            return Json(new { success = true, isDuplicate });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.IsInRole(Roles.Admin.ToString()))
                return RedirectToAction("Index", "Home").WithDanger("Error", "Only Admins are allowed access to delete functionality and records.");

            var caregiver = await _caregiverService.GetCaregiverByIdAsync(id);

            if (caregiver == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding caregiver.");

            await _caregiverService.DeleteCaregiver(id, _userName);

            return RedirectToAction(nameof(Index), "Home").WithSuccess("Success", $"{caregiver.FirstName} {caregiver.LastName} record has been deleted.");
        }

        [HttpPost]
        public async Task<IActionResult> Restore(int id)
        {
            if (!User.IsInRole(Roles.Admin.ToString()))
                return RedirectToAction("Index", "Home").WithDanger("Error", "Only Admins are allowed access to restore functionality and records.");

            var caregiver = await _caregiverService.GetCaregiverByIdAsync(id);

            if (caregiver == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding caregiver.");

            await _caregiverService.RestoreCaregiver(id, _userName);

            return RedirectToAction(nameof(Index), "Home").WithSuccess("Success", $"{caregiver.FirstName} {caregiver.LastName} record has been restored.");
        }

        public async Task<IActionResult> Deleted()
        {
            if (!User.IsInRole(Roles.Admin.ToString()))
                return RedirectToAction("Index", "Home").WithDanger("Error", "Only Admins are allowed access to delete functionality and records.");

            return View();
        }
    }
}
