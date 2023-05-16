using FHHL.BLL.Interfaces;
using FHHL.Data.Context;
using FHHL.Data.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHHL.BLL.Services
{
    public class OptionsService : IOptionsService
    {
        private readonly Func<FHHLDbContext> dbFactory;

        public OptionsService(Func<FHHLDbContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        #region Races
        public async Task<List<Race>> GetRacesAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Races
                .AsNoTracking()              
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> GetRacesSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var races = dbContext.Races.Where(a => !a.DelFlag && a.ActiveFlag);

            return await races.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }

        public async Task CreateRace(string raceName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var race = new Race
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = raceName
            };

            dbContext.Races.Add(race);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditRace(string newRaceName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var race = await dbContext.Races
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            race.Label = newRaceName;
            race.ChgDateTimeOffset = DateTimeOffset.Now;
            race.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task ToggleRaceActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var race = await dbContext.Races
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            race.ActiveFlag = !race.ActiveFlag;
            race.ChgDateTimeOffset = DateTimeOffset.Now;
            race.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Assignees
        public async Task<List<Assignee>> GetAssigneesAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Assignees
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Assignee> GetAssigneeByIdAsync(int id)
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Assignees
                .AsNoTracking()
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task CreateAssignee(string assigneeName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var assignee = new Assignee
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = assigneeName
            };

            dbContext.Assignees.Add(assignee);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditAssignee(string newAssigneeName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var assignee = await dbContext.Assignees
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            assignee.Label = newAssigneeName;
            assignee.ChgDateTimeOffset = DateTimeOffset.Now;
            assignee.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task ToggleAssigneeActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var assignee = await dbContext.Assignees
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            assignee.ActiveFlag = !assignee.ActiveFlag;
            assignee.ChgDateTimeOffset = DateTimeOffset.Now;
            assignee.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task<List<SelectListItem>> GetAssigneeSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var assignees = dbContext.Assignees.Where(a => !a.DelFlag);

            return await assignees.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }
        #endregion

        #region Pregnancy States
        public async Task<List<PregnancyState>> GetPregnancyStatesAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.PregnancyStates
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> GetPregnancyStatesSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var pregnancyStates = dbContext.PregnancyStates.Where(a => !a.DelFlag);

            return await pregnancyStates.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }

        public async Task CreatePregnancyState(string pregnancyStateName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var pregnancyState = new PregnancyState
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = pregnancyStateName
            };

            dbContext.PregnancyStates.Add(pregnancyState);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditPregnancyState(string newPregnancyStateName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var pregnancyState = await dbContext.PregnancyStates
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            pregnancyState.Label = newPregnancyStateName;
            pregnancyState.ChgDateTimeOffset = DateTimeOffset.Now;
            pregnancyState.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task TogglePregnancyStateActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var pregnancyState = await dbContext.PregnancyStates
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            pregnancyState.ActiveFlag = !pregnancyState.ActiveFlag;
            pregnancyState.ChgDateTimeOffset = DateTimeOffset.Now;
            pregnancyState.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Referral Sources
        public async Task<List<ReferralSource>> GetReferralSourcesAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.ReferralSources
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> GetReferralSourcesSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var referralSources = dbContext.ReferralSources.Where(a => !a.DelFlag);

            return await referralSources.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }

        public async Task CreateReferralSource(string referralSourceName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var referralSource = new ReferralSource
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = referralSourceName
            };

            dbContext.ReferralSources.Add(referralSource);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditReferralSource(string newReferralSourceName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var referralSource = await dbContext.ReferralSources
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            referralSource.Label = newReferralSourceName;
            referralSource.ChgDateTimeOffset = DateTimeOffset.Now;
            referralSource.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task ToggleReferralSourceActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var referralSource = await dbContext.ReferralSources
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            referralSource.ActiveFlag = !referralSource.ActiveFlag;
            referralSource.ChgDateTimeOffset = DateTimeOffset.Now;
            referralSource.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Risk Levels
        public async Task<List<RiskLevel>> GetRiskLevelsAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.RiskLevels
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> GetRiskLevelsSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var riskLevels = dbContext.RiskLevels.Where(a => !a.DelFlag);

            return await riskLevels.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }

        public async Task CreateRiskLevel(string riskLevelName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var riskLevel = new RiskLevel
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = riskLevelName
            };

            dbContext.RiskLevels.Add(riskLevel);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditRiskLevel(string newRiskLevelName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var riskLevel = await dbContext.RiskLevels
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            riskLevel.Label = newRiskLevelName;
            riskLevel.ChgDateTimeOffset = DateTimeOffset.Now;
            riskLevel.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task ToggleRiskLevelActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var riskLevel = await dbContext.RiskLevels
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            riskLevel.ActiveFlag = !riskLevel.ActiveFlag;
            riskLevel.ChgDateTimeOffset = DateTimeOffset.Now;
            riskLevel.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Programs
        public async Task<List<Program>> GetProgramsAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Programs
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> GetProgramsSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var programs = dbContext.Programs.Where(a => !a.DelFlag);

            return await programs.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }

        public async Task CreateProgram(string programName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var program = new Program
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = programName
            };

            dbContext.Programs.Add(program);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditProgram(string newProgramName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var program = await dbContext.Programs
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            program.Label = newProgramName;
            program.ChgDateTimeOffset = DateTimeOffset.Now;
            program.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task ToggleProgramActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var program = await dbContext.Programs
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            program.ActiveFlag = !program.ActiveFlag;
            program.ChgDateTimeOffset = DateTimeOffset.Now;
            program.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Visit Results
        public async Task<List<VisitResult>> GetVisitResultsAsync()
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.VisitResults
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> GetVisitResultsSelectList()
        {
            using var dbContext = dbFactory.Invoke();

            var visitResults = dbContext.VisitResults.Where(a => !a.DelFlag);

            return await visitResults.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Label
            }).ToListAsync();
        }

        public async Task CreateVisitResult(string visitResultName, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var visitResult = new VisitResult
            {
                AddDateTimeOffset = DateTimeOffset.Now,
                AddUser = userName,
                ActiveFlag = true,
                Label = visitResultName
            };

            dbContext.VisitResults.Add(visitResult);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditVisitResult(string newVisitResultName, int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var visitResult = await dbContext.VisitResults
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            visitResult.Label = newVisitResultName;
            visitResult.ChgDateTimeOffset = DateTimeOffset.Now;
            visitResult.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task ToggleVisitResultActiveFlag(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var visitResult = await dbContext.VisitResults
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            visitResult.ActiveFlag = !visitResult.ActiveFlag;
            visitResult.ChgDateTimeOffset = DateTimeOffset.Now;
            visitResult.ChgUser = userName;

            await dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
