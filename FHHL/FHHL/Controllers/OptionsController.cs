using Common.Web.Alerts;
using Common.Web.Extensions;
using FHHL.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHHL.Web.Controllers
{
    [Authorize]
    public class OptionsController : Controller
    {
        private readonly IOptionsService _optionsService;

        public OptionsController(IOptionsService optionsService)
        {
            _optionsService = optionsService;
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

        #region Race
        public async Task<IActionResult> Races()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRace(string newRaceName)
        {
            if (string.IsNullOrWhiteSpace(newRaceName))
                return RedirectToAction(nameof(Races)).WithDanger("Error", "The new race cannot be blank.");

            await _optionsService.CreateRace(newRaceName, _userName);

            return RedirectToAction(nameof(Races)).WithSuccess("Success", $"{newRaceName} was successfully added to your list of race options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditRace(string changedRaceName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedRaceName))
                return RedirectToAction(nameof(Races)).WithDanger("Error", "The new race cannot be blank.");

            await _optionsService.EditRace(changedRaceName, id, _userName);

            return RedirectToAction(nameof(Races)).WithSuccess("Success", $"{changedRaceName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleRaceActiveFlag(int raceId)
        {
            await _optionsService.ToggleRaceActiveFlag(raceId, _userName);

            return RedirectToAction(nameof(Races)).WithSuccess("Success", $"The selected race was toggled.");
        }
        #endregion

        #region Assignees
        public async Task<IActionResult> Assignees()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssignee(string newAssigneeName)
        {
            if (string.IsNullOrWhiteSpace(newAssigneeName))
                return RedirectToAction(nameof(Assignees)).WithDanger("Error", "The new assignee cannot be blank.");

            await _optionsService.CreateAssignee(newAssigneeName, _userName);

            return RedirectToAction(nameof(Assignees)).WithSuccess("Success", $"{newAssigneeName} was successfully added to your list of assignee options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditAssignee(string changedAssigneeName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedAssigneeName))
                return RedirectToAction(nameof(Assignees)).WithDanger("Error", "The new assignee cannot be blank.");

            await _optionsService.EditAssignee(changedAssigneeName, id, _userName);

            return RedirectToAction(nameof(Assignees)).WithSuccess("Success", $"{changedAssigneeName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleAssigneeActiveFlag(int assigneeId)
        {
            await _optionsService.ToggleAssigneeActiveFlag(assigneeId, _userName);

            return RedirectToAction(nameof(Assignees)).WithSuccess("Success", $"The selected assignee was toggled.");
        }
        #endregion

        #region Pregnancy States
        public async Task<IActionResult> PregnancyStates()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePregnancyState(string newPregnancyStateName)
        {
            if (string.IsNullOrWhiteSpace(newPregnancyStateName))
                return RedirectToAction(nameof(PregnancyStates)).WithDanger("Error", "The new pregnancy state cannot be blank.");

            await _optionsService.CreatePregnancyState(newPregnancyStateName, _userName);

            return RedirectToAction(nameof(PregnancyStates)).WithSuccess("Success", $"{newPregnancyStateName} was successfully added to your list of pregnancy state options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditPregnancyState(string changedPregnancyStateName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedPregnancyStateName))
                return RedirectToAction(nameof(PregnancyStates)).WithDanger("Error", "The new pregnancy state cannot be blank.");

            await _optionsService.EditPregnancyState(changedPregnancyStateName, id, _userName);

            return RedirectToAction(nameof(PregnancyStates)).WithSuccess("Success", $"{changedPregnancyStateName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> TogglePregnancyStateActiveFlag(int PregnancyStateId)
        {
            await _optionsService.TogglePregnancyStateActiveFlag(PregnancyStateId, _userName);

            return RedirectToAction(nameof(PregnancyStates)).WithSuccess("Success", $"The selected pregnancy state was toggled.");
        }
        #endregion

        #region Referral Sources
        public async Task<IActionResult> ReferralSources()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateReferralSource(string newReferralSourceName)
        {
            if (string.IsNullOrWhiteSpace(newReferralSourceName))
                return RedirectToAction(nameof(ReferralSources)).WithDanger("Error", "The new referral source cannot be blank.");

            await _optionsService.CreateReferralSource(newReferralSourceName, _userName);

            return RedirectToAction(nameof(ReferralSources)).WithSuccess("Success", $"{newReferralSourceName} was successfully added to your list of referral source options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditReferralSource(string changedReferralSourceName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedReferralSourceName))
                return RedirectToAction(nameof(ReferralSources)).WithDanger("Error", "The new referral source cannot be blank.");

            await _optionsService.EditReferralSource(changedReferralSourceName, id, _userName);

            return RedirectToAction(nameof(ReferralSources)).WithSuccess("Success", $"{changedReferralSourceName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleReferralSourceActiveFlag(int ReferralSourceId)
        {
            await _optionsService.ToggleReferralSourceActiveFlag(ReferralSourceId, _userName);

            return RedirectToAction(nameof(ReferralSources)).WithSuccess("Success", $"The selected referral source was toggled.");
        }
        #endregion

        #region Risk Levels
        public async Task<IActionResult> RiskLevels()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRiskLevel(string newRiskLevelName)
        {
            if (string.IsNullOrWhiteSpace(newRiskLevelName))
                return RedirectToAction(nameof(RiskLevels)).WithDanger("Error", "The new risk level cannot be blank.");

            await _optionsService.CreateRiskLevel(newRiskLevelName, _userName);

            return RedirectToAction(nameof(RiskLevels)).WithSuccess("Success", $"{newRiskLevelName} was successfully added to your list of risk level options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditRiskLevel(string changedRiskLevelName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedRiskLevelName))
                return RedirectToAction(nameof(RiskLevels)).WithDanger("Error", "The new risk level cannot be blank.");

            await _optionsService.EditRiskLevel(changedRiskLevelName, id, _userName);

            return RedirectToAction(nameof(RiskLevels)).WithSuccess("Success", $"{changedRiskLevelName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleRiskLevelActiveFlag(int RiskLevelId)
        {
            await _optionsService.ToggleRiskLevelActiveFlag(RiskLevelId, _userName);

            return RedirectToAction(nameof(RiskLevels)).WithSuccess("Success", $"The selected risk level was toggled.");
        }
        #endregion

        #region Programs
        public async Task<IActionResult> Programs()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgram(string newProgramName)
        {
            if (string.IsNullOrWhiteSpace(newProgramName))
                return RedirectToAction(nameof(Programs)).WithDanger("Error", "The new program cannot be blank.");

            await _optionsService.CreateProgram(newProgramName, _userName);

            return RedirectToAction(nameof(Programs)).WithSuccess("Success", $"{newProgramName} was successfully added to your list of program options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditProgram(string changedProgramName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedProgramName))
                return RedirectToAction(nameof(Programs)).WithDanger("Error", "The new program cannot be blank.");

            await _optionsService.EditProgram(changedProgramName, id, _userName);

            return RedirectToAction(nameof(Programs)).WithSuccess("Success", $"{changedProgramName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleProgramActiveFlag(int programId)
        {
            await _optionsService.ToggleProgramActiveFlag(programId, _userName);

            return RedirectToAction(nameof(Programs)).WithSuccess("Success", $"The selected program was toggled.");
        }
        #endregion

        #region VisitResult
        public async Task<IActionResult> VisitResults()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateVisitResult(string newVisitResultName)
        {
            if (string.IsNullOrWhiteSpace(newVisitResultName))
                return RedirectToAction(nameof(VisitResults)).WithDanger("Error", "The new visit result cannot be blank.");

            await _optionsService.CreateVisitResult(newVisitResultName, _userName);

            return RedirectToAction(nameof(VisitResults)).WithSuccess("Success", $"{newVisitResultName} was successfully added to your list of visit result options.");
        }

        [HttpPost]
        public async Task<IActionResult> EditVisitResult(string changedVisitResultName, int id)
        {
            if (string.IsNullOrWhiteSpace(changedVisitResultName))
                return RedirectToAction(nameof(VisitResults)).WithDanger("Error", "The new visit result cannot be blank.");

            await _optionsService.EditVisitResult(changedVisitResultName, id, _userName);

            return RedirectToAction(nameof(VisitResults)).WithSuccess("Success", $"{changedVisitResultName} was successfully modified.");
        }

        [HttpPost]
        public async Task<IActionResult> ToggleVisitResultActiveFlag(int VisitResultId)
        {
            await _optionsService.ToggleVisitResultActiveFlag(VisitResultId, _userName);

            return RedirectToAction(nameof(VisitResults)).WithSuccess("Success", $"The selected visit result was toggled.");
        }

        #endregion
    }
}
