using FHHL.Data.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FHHL.BLL.Interfaces
{
    public interface IOptionsService
    {
        Task<List<Race>> GetRacesAsync();
        Task<List<SelectListItem>> GetRacesSelectList();

        Task CreateRace(string raceName, string userName);
        Task EditRace(string newRaceName, int id, string userName);
        Task ToggleRaceActiveFlag(int id, string userName);


        Task<List<Assignee>> GetAssigneesAsync();
        Task<Assignee> GetAssigneeByIdAsync(int id);
        Task<List<SelectListItem>> GetAssigneeSelectList();
        Task CreateAssignee(string assigneeName, string userName);
        Task EditAssignee(string newAssigneeName, int id, string userName);
        Task ToggleAssigneeActiveFlag(int id, string userName);


        Task<List<PregnancyState>> GetPregnancyStatesAsync();
        Task<List<SelectListItem>> GetPregnancyStatesSelectList();
        Task CreatePregnancyState(string pregnancyStateName, string userName);
        Task EditPregnancyState(string newPregnancyStateName, int id, string userName);
        Task TogglePregnancyStateActiveFlag(int id, string userName);


        Task<List<ReferralSource>> GetReferralSourcesAsync();
        Task<List<SelectListItem>> GetReferralSourcesSelectList();
        Task CreateReferralSource(string referralSourceName, string userName);
        Task EditReferralSource(string newReferralSourceName, int id, string userName);
        Task ToggleReferralSourceActiveFlag(int id, string userName);


        Task<List<RiskLevel>> GetRiskLevelsAsync();
        Task<List<SelectListItem>> GetRiskLevelsSelectList();
        Task CreateRiskLevel(string riskLevelName, string userName);
        Task EditRiskLevel(string newRiskLevelName, int id, string userName);
        Task ToggleRiskLevelActiveFlag(int id, string userName);


        Task<List<Program>> GetProgramsAsync();
        Task<List<SelectListItem>> GetProgramsSelectList();
        Task CreateProgram(string programName, string userName);
        Task EditProgram(string newProgramName, int id, string userName);
        Task ToggleProgramActiveFlag(int id, string userName);


        Task<List<VisitResult>> GetVisitResultsAsync();
        Task<List<SelectListItem>> GetVisitResultsSelectList();
        Task CreateVisitResult(string visitResultName, string userName);
        Task EditVisitResult(string newVisitResultName, int id, string userName);
        Task ToggleVisitResultActiveFlag(int id, string userName);
    }
}
