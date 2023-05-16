using FHHL.BLL.Interfaces;
using FHHL.Data.Context;
using FHHL.Data.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHHL.BLL.Services
{
    public class ReferralService:IReferralService
    {
        private readonly Func<FHHLDbContext> dbFactory;

        public ReferralService(Func<FHHLDbContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public async Task<Referral> GetRecordByIdAsync(int id)
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Referrals.Where(r => r.Id == id).Include(r => r.ReferralRaces).Include(r => r.ReferralReferralSources).SingleOrDefaultAsync();
        }

        public async Task CreateRecord(Referral record, List<int> selectedRaceIds, List<int> selectedReferralSourceIds)
        {
            using var dbContext = dbFactory.Invoke();

            if (selectedRaceIds == null)
                selectedRaceIds = new List<int>();

            record.ReferralRaces = selectedRaceIds.Select(x => new ReferralRace()
            {
                RaceId = x
            }).ToList();

            if (selectedReferralSourceIds == null)
                selectedReferralSourceIds = new List<int>();

            record.ReferralReferralSources = selectedReferralSourceIds.Select(x => new ReferralReferralSource()
            {
                ReferralSourceId = x
            }).ToList();

            dbContext.Referrals.Add(record);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<string>> GetAllRecordYearsAsync()
        {
            using var dbContext = dbFactory.Invoke();

            IQueryable<string> records = dbContext.Referrals.Select(r => r.ReferralDate.Year.ToString()).Distinct().OrderByDescending(x => x);

            return records.ToList();
        }

        public async Task<List<ReferralRace>> GetReferralRacesByReferralId(int id)
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.ReferralRaces.Where(r => r.ReferralId == id).ToListAsync();
        }

        public async Task EditRecord(Referral newRecord, List<int> selectedRaces, List<int> selectedReferralSources)
        {
            using var dbContext = dbFactory.Invoke();

            var currentRecord = await dbContext.Referrals.Where(r => r.Id == newRecord.Id).Include(r => r.ReferralRaces).Include(r => r.ReferralReferralSources).SingleOrDefaultAsync();
            var currentRecordRaces = await dbContext.ReferralRaces.Where(r => r.ReferralId == currentRecord.Id).ToListAsync();
            var currentRecordReferralSources = await dbContext.ReferralReferralSources.Where(r => r.ReferralId == currentRecord.Id).ToListAsync();

            currentRecord.AssignDate = newRecord.AssignDate;
            currentRecord.AssignedTo = newRecord.AssignedTo;
            currentRecord.ChgDateTimeOffset = DateTimeOffset.Now;
            currentRecord.ChgUser = newRecord.ChgUser;
            currentRecord.ChildDateOfBirth = newRecord.ChildDateOfBirth;
            currentRecord.ChildName = newRecord.ChildName;
            currentRecord.EstimatedDeliveryDate = newRecord.EstimatedDeliveryDate;
            currentRecord.FirstChild = newRecord.FirstChild;
            currentRecord.FtoF = newRecord.FtoF;
            currentRecord.LOR = newRecord.LOR;
            currentRecord.Notes = newRecord.Notes;
            currentRecord.Program = newRecord.Program;
            currentRecord.ReferralDate = newRecord.ReferralDate;
            currentRecord.ReferralReason = newRecord.ReferralReason;
            currentRecord.Result = newRecord.Result;
            currentRecord.ResultDate = newRecord.ResultDate;
            currentRecord.Type = newRecord.Type;

            if (selectedRaces == null)
                selectedRaces = new List<int>();

            foreach (var r in selectedRaces)
            {
                if (!currentRecordRaces.Any(x => x.RaceId == r))
                {
                    dbContext.ReferralRaces.Add(new ReferralRace()
                    {
                        RaceId = r,
                        ReferralId = currentRecord.Id
                    });
                }
            }

            foreach (var r in currentRecordRaces)
            {
                if (!selectedRaces.Contains(r.RaceId))
                {
                    dbContext.ReferralRaces.Remove(r);
                }
            }

            if (selectedReferralSources == null)
                selectedReferralSources = new List<int>();

            foreach (var r in selectedReferralSources)
            {
                if (!currentRecordReferralSources.Any(x => x.ReferralSourceId == r))
                {
                    dbContext.ReferralReferralSources.Add(new ReferralReferralSource()
                    {
                        ReferralSourceId = r,
                        ReferralId = currentRecord.Id
                    });
                }
            }

            foreach (var r in currentRecordReferralSources)
            {
                if (!selectedReferralSources.Contains(r.ReferralSourceId))
                {
                    dbContext.ReferralReferralSources.Remove(r);
                }
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Referral>> GetReferralsByCaregiverIdAsync(int id)
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Referrals.Where(r => r.CaregiverId == id).ToListAsync();
        }

        public async Task<List<Referral>> GetReferralsFilteredAsync(DateTimeOffset? referralDateStart, DateTimeOffset? referralDateEnd, string caregiverName, string childName, int? assignedTo, List<int> referralSourceIds, int? result, int? program, bool deletedRecords)
        {
            using var dbContext = dbFactory.Invoke();

            IQueryable<Referral> referrals = dbContext.Referrals.Include(r => r.Caregiver).Include(r => r.ReferralReferralSources);

            if (referralDateStart.HasValue && !referralDateEnd.HasValue)
            {
                referrals = referrals.Where(r => r.ReferralDate.Date >= referralDateStart.Value.Date);
            }
            else if (referralDateEnd.HasValue && !referralDateStart.HasValue)
            {
                referrals = referrals.Where(r => r.ReferralDate.Date <= referralDateEnd.Value.Date);
            }
            else if (referralDateEnd.HasValue && referralDateStart.HasValue)
            {
                referrals = referrals.Where(r => r.ReferralDate.Date <= referralDateEnd.Value.Date && r.ReferralDate.Date >= referralDateStart.Value.Date);
            }


            if (!string.IsNullOrEmpty(caregiverName))
            {
                referrals = referrals.Where(r => r.Caregiver.FullName.ToLower().Contains(caregiverName.ToLower()));
            }

            if (!string.IsNullOrEmpty(childName))
            {
                referrals = referrals.Where(r => r.ChildName.ToLower().Contains(childName.ToLower()));
            }

            if (assignedTo.HasValue)
            {
                if (assignedTo == 0)
                {
                    referrals = referrals.Where(r => !r.AssignedTo.HasValue);
                } else
                {
                    referrals = referrals.Where(r => r.AssignedTo == assignedTo);
                }
            }

            if (result.HasValue)
            {
                if (result == 0)
                {
                    referrals = referrals.Where(r => !r.Result.HasValue);
                }
                else
                {
                    referrals = referrals.Where(r => r.Result == result);
                }
            }

            if (program.HasValue)
            {
                if (program == 0)
                {
                    referrals = referrals.Where(r => !r.Program.HasValue);
                }
                else
                {
                    referrals = referrals.Where(r => r.Program == program);
                }
            }

            if (referralSourceIds != null)
            { 
                referrals = referrals.Where(r => r.ReferralReferralSources.Any(s => referralSourceIds.Contains(s.ReferralSourceId)));
            }

            referrals = deletedRecords ? referrals.Where(r => r.DelFlag || r.Caregiver.DelFlag) : referrals.Where(r => !r.DelFlag && !r.Caregiver.DelFlag);

            referrals = referrals.OrderByDescending(r => r.ReferralDate).Take(500);


            return referrals.ToList();
        }

        public async Task DeleteReferral(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var referral = await dbContext.Referrals.Where(r => r.Id == id).SingleOrDefaultAsync();

            referral.DelDateTimeOffset = DateTimeOffset.Now;
            referral.DelFlag = true;
            referral.DelUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task RestoreReferral(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var referrals = await dbContext.Referrals.Where(r => r.Id == id).SingleOrDefaultAsync();

            referrals.DelDateTimeOffset = null;
            referrals.DelFlag = false;
            referrals.DelUser = null;

            await dbContext.SaveChangesAsync();
        }
    }
}
