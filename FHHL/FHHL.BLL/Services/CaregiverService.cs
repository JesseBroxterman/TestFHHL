using FHHL.BLL.Interfaces;
using FHHL.Data.Context;
using FHHL.Data.DomainModels;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHHL.BLL.Services
{
    public class CaregiverService:ICaregiverService
    {
        private readonly Func<FHHLDbContext> dbFactory;

        public CaregiverService(Func<FHHLDbContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public async Task<Caregiver> GetCaregiverByIdAsync(int id)
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.Caregivers.Where(r => r.Id == id).SingleOrDefaultAsync();
        }

        public async Task<List<CaregiverRace>> GetCaregiverRacesByCaregiverId(int id)
        {
            using var dbContext = dbFactory.Invoke();

            return await dbContext.CaregiverRaces.Where(r => r.CaregiverId == id).ToListAsync();
        }

        public async Task<bool> CheckForCaregiverByNameAndDoB(string firstName, string lastName, DateTimeOffset doB)
        {
            using var dbContext = dbFactory.Invoke();

            var caregivers = await dbContext.Caregivers.Where(
                c => c.DateOfBirth == doB &&
                c.FirstName == firstName &&
                c.LastName == lastName).ToListAsync();

            if (caregivers.Count > 0)
                return true;

            return false;
        }

        public async Task CreateCaregiver(Caregiver caregiver, List<int> raceIds)
        {
            using var dbContext = dbFactory.Invoke();

            caregiver.CaregiverRaces = raceIds?.Select(x => new CaregiverRace()
            {
                RaceId = x
            }).ToList();

            dbContext.Caregivers.Add(caregiver);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditCaregiver(Caregiver newCaregiver, List<int> raceIds)
        {
            using var dbContext = dbFactory.Invoke();

            var currentCaregiver = await dbContext.Caregivers.Where(r => r.Id == newCaregiver.Id).SingleOrDefaultAsync();
            var currentCaregiverRaces = await GetCaregiverRacesByCaregiverId(currentCaregiver.Id);

            currentCaregiver.ChgDateTimeOffset = newCaregiver.ChgDateTimeOffset;
            currentCaregiver.ChgUser = newCaregiver.ChgUser;
            currentCaregiver.DateOfBirth = newCaregiver.DateOfBirth;
            currentCaregiver.FirstName = newCaregiver.FirstName;
            currentCaregiver.LastName = newCaregiver.LastName;
            currentCaregiver.MomClass = newCaregiver.MomClass;
            currentCaregiver.Spanish = newCaregiver.Spanish;
            currentCaregiver.Zip = newCaregiver.Zip;
            currentCaregiver.Foster = newCaregiver.Foster;

            if (raceIds == null)
                raceIds = new List<int>();

            foreach (var r in raceIds)
            {
                if (!currentCaregiverRaces.Any(x => x.RaceId == r))
                {
                    dbContext.CaregiverRaces.Add(new CaregiverRace()
                    {
                        RaceId = r,
                        CaregiverId = currentCaregiver.Id
                    });
                }
            }

            foreach (var r in currentCaregiverRaces)
            {
                if (!raceIds.Contains(r.RaceId))
                {
                    dbContext.CaregiverRaces.Remove(r);
                }
            }
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Caregiver>> GetCaregiversFilteredAsync(DateTimeOffset? referralDateStart, DateTimeOffset? referralDateEnd, string caregiverName, string childName, int? assignedTo, DateTimeOffset? dateOfBirth)
        {
            using var dbContext = dbFactory.Invoke();

            IQueryable<Caregiver> caregivers = dbContext.Caregivers.Include(r => r.Referrals);

            if (referralDateStart.HasValue && !referralDateEnd.HasValue)
            {
                caregivers = caregivers.Where(c => c.Referrals.Any(r => r.ReferralDate.Date >= referralDateStart.Value.Date));
            } 
            else if (referralDateEnd.HasValue && !referralDateStart.HasValue)
            {
                caregivers = caregivers.Where(c => c.Referrals.Any(r => r.ReferralDate.Date <= referralDateEnd.Value.Date));
            } 
            else if (referralDateEnd.HasValue && referralDateStart.HasValue)
            {
                caregivers = caregivers.Where(c => c.Referrals.Any(r => r.ReferralDate.Date <= referralDateEnd.Value.Date && r.ReferralDate.Date >= referralDateStart.Value.Date));
            }


            if (!string.IsNullOrEmpty(caregiverName))
            {
                caregivers = caregivers.Where(r => r.FullName.ToLower().Contains(caregiverName.ToLower()));
            }

            if (!string.IsNullOrEmpty(childName))
            {
                caregivers = caregivers.Where(c => c.Referrals.Any(r => r.ChildName.ToLower().Contains(childName.ToLower())));
            }

            if (assignedTo.HasValue)
            {
                caregivers = caregivers.Where(c => c.Referrals.Any(r => r.AssignedTo == assignedTo));
            }

            if (dateOfBirth.HasValue)
            {
                caregivers = caregivers.Where(r => r.DateOfBirth.HasValue && r.DateOfBirth.Value.Date == dateOfBirth.Value.Date);
            }

            caregivers = caregivers.Select(c => new Caregiver() { 
                Id = c.Id,
                AddDateTimeOffset = c.AddDateTimeOffset,
                FullName = c.FullName,
                DateOfBirth = c.DateOfBirth,
                Referrals = c.Referrals,
                DelFlag = c.DelFlag,
            }).AsNoTracking().AsExpandable();

            caregivers = caregivers.OrderByDescending(c => c.Referrals.OrderByDescending(r => r.ReferralDate).First()).Take(500);


            return caregivers.ToList();
        }

        public async Task DeleteCaregiver(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var caregiver = await dbContext.Caregivers.Where(r => r.Id == id).SingleOrDefaultAsync();

            caregiver.DelDateTimeOffset = DateTimeOffset.Now;
            caregiver.DelFlag = true;
            caregiver.DelUser = userName;

            await dbContext.SaveChangesAsync();
        }

        public async Task RestoreCaregiver(int id, string userName)
        {
            using var dbContext = dbFactory.Invoke();

            var caregiver = await dbContext.Caregivers.Where(r => r.Id == id).SingleOrDefaultAsync();

            caregiver.DelDateTimeOffset = null;
            caregiver.DelFlag = false;
            caregiver.DelUser = null;

            await dbContext.SaveChangesAsync();
        }

    }
}
