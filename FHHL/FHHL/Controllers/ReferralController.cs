using FHHL.BLL.Interfaces;
using FHHL.Data.DomainModels;
using FHHL.Web.Models.Record;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Web.Alerts;
using Microsoft.AspNetCore.Authorization;
using FHHL.Web.Models.Referral;
using FHHL.Web.Models;
using FHHL.Data.Extensions;

namespace FHHL.Web.Controllers
{
    [Authorize]
    public class ReferralController : Controller
    {
        private readonly IReferralService _referralService;
        private readonly IOptionsService _optionsService;
        private readonly ICaregiverService _caregiverService;

        public ReferralController(IReferralService referralService, IOptionsService optionsService, ICaregiverService caregiverService)
        {
            _referralService = referralService;
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

        public async Task<IActionResult> Search()
        {
            return View();
        }

        public async Task<IActionResult> RecordSearchAjax(SearchViewModel vm)
        {
            var records = await _referralService.GetReferralsFilteredAsync(vm.ReferralDateStart, vm.ReferralDateEnd, vm.CaregiverName, vm.ChildName, vm.AssignedTo, vm.ReferralSourceIds, vm.Result, vm.Program, vm.DeletedRecords);

            var assignees = await _optionsService.GetAssigneesAsync();
            var programs = await _optionsService.GetProgramsAsync();
            var referralSources = await _optionsService.GetReferralSourcesAsync();
            var results = await _optionsService.GetVisitResultsAsync();

            var jsonResult = new DataTablesJsonResult<ReferralJson>();

            jsonResult.data = records.Select(r => new ReferralJson
            {
                Id = r.Id,
                ReferralDate = r.ReferralDate.ToString("d"),
                ReferralDateSortable = r.ReferralDate.ToString("yyyy-MM-dd"),
                CaregiverName = r.Caregiver.FullName,
                ChildName = r.ChildName,
                AssignedTo = assignees.SingleOrDefault(a => a.Id == r.AssignedTo)?.Label,
                Program = programs.SingleOrDefault(p => p.Id == r.Program)?.Label,
                ReferralSourceIds = r.ReferralReferralSources.Select(s => s.ReferralSourceId).ToList(),
                ReferralSourceLabels = new List<string>(),
                Result = results.SingleOrDefault(x => x.Id == r.Result)?.Label
            }).ToArray();

            foreach (var j in jsonResult.data)
            {
                foreach (var r in j.ReferralSourceIds)
                {
                    var referralSource = referralSources.Single(x => x.Id == r);
                    j.ReferralSourceLabels.Add(referralSource.Label);
                }
            }

            jsonResult.draw = 1;
            jsonResult.recordsFiltered = jsonResult.data.Count();
            jsonResult.recordsTotal = jsonResult.data.Count();

            return Json(jsonResult);
        }

        public async Task<IActionResult> Create(int caregiverId)
        {
            var caregiver = await _caregiverService.GetCaregiverByIdAsync(caregiverId);

            if (caregiver == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding caregiver.");

            var vm = new CreateViewModel() { 
                CaregiverId = caregiverId,
                CaregiverName = caregiver.FirstName + ' ' + caregiver.LastName
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model).WithDanger("Error", "There are errors on the form.");

            var referral = new Referral()
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = _userName,
                AssignDate = model.AssignDate,
                AssignedTo = model.AssignedTo,
                CaregiverId = model.CaregiverId,
                ChildDateOfBirth = model.ChildDateOfBirth,
                ChildName = model.ChildName,
                EstimatedDeliveryDate = model.EDC,
                FirstChild = model.FirstChild,
                FtoF = model.FtoF,
                LOR = model.LOR,
                Notes = model.Notes,
                Program = model.Program,
                ReferralDate = model.ReferralDate,
                ReferralReason = model.ReferralReason,
                Result = model.Result,
                ResultDate = model.ResultDate,
                Type = model.Type
            };

            await _referralService.CreateRecord(referral, model.SelectedRaces, model.SelectedReferralSources);

            return RedirectToAction("Dashboard", "Caregiver", new { id = model.CaregiverId }).WithSuccess("Success", "Referral has been added.");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var referral = await _referralService.GetRecordByIdAsync(id);

            if (referral == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding referral.");

            var caregiver = await _caregiverService.GetCaregiverByIdAsync(referral.CaregiverId);

            if (caregiver == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding caregiver.");

            var vm = new EditViewModel()
            {
                AssignDate = referral.AssignDate,
                AssignedTo = referral.AssignedTo,
                CaregiverId = referral.CaregiverId,
                CaregiverName = caregiver.FirstName + ' ' + caregiver.LastName,
                ChildDateOfBirth = referral.ChildDateOfBirth,
                ChildName = referral.ChildName,
                DelFlag = referral.DelFlag,
                EDC = referral.EstimatedDeliveryDate,
                FirstChild = referral.FirstChild,
                FtoF = referral.FtoF,
                Id = referral.Id,
                LOR = referral.LOR,
                Notes = referral.Notes,
                Program = referral.Program,
                ReferralDate = referral.ReferralDate,
                ReferralReason = referral.ReferralReason,
                Result = referral.Result,
                ResultDate = referral.ResultDate,
                Type = referral.Type,
                SelectedRaces = referral.ReferralRaces.Select(r => r.RaceId).Distinct().ToList(),
                SelectedReferralSources = referral.ReferralReferralSources.Select(r => r.ReferralSourceId).Distinct().ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model).WithDanger("Error", "There are errors on the form.");

            var referral = new Referral()
            {
                AssignDate = model.AssignDate,
                AssignedTo = model.AssignedTo,
                ChgUser = _userName,
                CaregiverId = model.CaregiverId,
                ChildDateOfBirth = model.ChildDateOfBirth,
                ChildName = model.ChildName,
                FirstChild = model.FirstChild,
                FtoF = model.FtoF,
                EstimatedDeliveryDate =  model.EDC,
                Id = model.Id,
                LOR = model.LOR,
                Notes = model.Notes,
                Program = model.Program,
                ReferralDate = model.ReferralDate,
                ReferralReason = model.ReferralReason,
                Result = model.Result,
                ResultDate = model.ResultDate,
                Type = model.Type
            };

            await _referralService.EditRecord(referral, model.SelectedRaces, model.SelectedReferralSources);

            return RedirectToAction("Dashboard", "Caregiver", new { id = model.CaregiverId}).WithSuccess("Success", "Referral has been updated.");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.IsInRole(Roles.Admin.ToString()))
                return RedirectToAction("Index", "Home").WithDanger("Error", "Only Admins are allowed access to delete functionality and records.");

            var referral = await _referralService.GetRecordByIdAsync(id);

            if (referral == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding referral.");

            await _referralService.DeleteReferral(id, _userName);

            return RedirectToAction("Dashboard", "Caregiver", new { id = referral.CaregiverId }).WithSuccess("Success", "Referral record has been deleted.");
        }

        [HttpPost]
        public async Task<IActionResult> Restore(int id)
        {
            if (!User.IsInRole(Roles.Admin.ToString()))
                return RedirectToAction("Index", "Home").WithDanger("Error", "Only Admins are allowed access to restore functionality.");


            var referral = await _referralService.GetRecordByIdAsync(id);

            if (referral == null)
                return RedirectToAction(nameof(Index), "Home").WithDanger("Error", "The system could not find the corresponding referral.");

            await _referralService.RestoreReferral(id, _userName);

            return RedirectToAction("Dashboard", "Caregiver", new { id = referral.CaregiverId }).WithSuccess("Success", "Referral record has been restored.");
        }

        public async Task<IActionResult> Deleted()
        {
            if (!User.IsInRole(Roles.Admin.ToString()))
                return RedirectToAction("Index", "Home").WithDanger("Error", "Only Admins are allowed access to delete functionality and records.");

            return View();
        }
    }
}
