using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FHHL.Web.Models.Home;
using FHHL.Web.Models;
using FHHL.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using FHHL.Data.Extensions;

namespace FHHL.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IOptionsService _optionsService;
        private readonly ICaregiverService _caregiverService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IOptionsService optionsService, ICaregiverService caregiverService, ILogger<HomeController> logger)
        {
            _optionsService = optionsService;
            _caregiverService = caregiverService;
            _logger = logger;
        }

        private string _userName
        {
            get
            {
                return User.Claims.Any(c => c.Type == "name") ? User.Claims.First(c => c.Type == "name").Value : User.Identity.Name ?? "Unknown";
            }
        }

        public async Task<IActionResult> Index()
        {
                return View();
        }

        public async Task<IActionResult> RecordSearchAjax(IndexViewModel vm)
        {
            var records = await _caregiverService.GetCaregiversFilteredAsync(vm.ReferralDateStart, vm.ReferralDateEnd, vm.CaregiverName, vm.ChildName, vm.AssignedTo, vm.DateOfBirth);
            var assignees = await _optionsService.GetAssigneesAsync();

            var jsonResult = new DataTablesJsonResult<RecordJson>();
            
            jsonResult.data = records.Where(r => r.DelFlag == vm.DeletedRecords).Select(d => new RecordJson
            {
                Id = d.Id,
                ReferralDates = d.Referrals.OrderByDescending(r => r.ReferralDate).Select(r => r.ReferralDate.ToString("d")).ToList(),
                ReferralDatesSortable = d.Referrals.OrderByDescending(r => r.ReferralDate).Select(r => r.ReferralDate.ToString("yyyy-MM-dd")).FirstOrDefault(),
                CaregiverName = d.FullName,
                ChildNames = d.Referrals.Where(r => r.ChildName != null).Select(r => r.ChildName).ToList(),
                AssignedTos = d.Referrals.Where(r => r.AssignedTo != null).Select(r => r.AssignedTo).ToList(),
                DateOfBirth = d.DateOfBirth?.Date.ToString("d") ?? "-",
                DateOfBirthSortable = d.DateOfBirth?.Date.ToString("yyyy-MM-dd") ?? "-",
                AssignedToLabels = new List<string>()
            }).ToArray();

            foreach (var j in jsonResult.data)
            {
                foreach (var r in j.AssignedTos)
                {
                    if (r.HasValue)
                    {
                        var assignee = assignees.Single(x => x.Id == r.Value);
                        j.AssignedToLabels.Add(assignee.Label);
                    }
                }
            }

            jsonResult.draw = 1;
            jsonResult.recordsFiltered = jsonResult.data.Count();
            jsonResult.recordsTotal = jsonResult.data.Count();

            return Json(jsonResult);
        }

        #region Errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        public IActionResult Error()
        {
            //this is the error that would have been redirected here by the global handler
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (exceptionFeature != null)
            {
                _logger.LogError("{userName} experienced {errorMessage} during transaction {transactionId}", _userName, exceptionFeature.Error.Message, Activity.Current?.Id);
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AllowAnonymous]
        public IActionResult ErrorTest()
        {
            throw new NotImplementedException();
        }

        [AllowAnonymous]
        public IActionResult ErrorAjaxTest()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ErrorAjaxTestPost()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
