using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FHHL.BLL.Interfaces
{
    public interface IReferralService
    {
        public Task CreateRecord(Referral record, List<int> selectedRaceIds, List<int> selectedReferralSourceIds);
        public Task<List<string>> GetAllRecordYearsAsync();
        Task<Referral> GetRecordByIdAsync(int id);
        Task EditRecord(Referral newRecord, List<int> selectedRaces, List<int> selectedReferralSources);
        public Task<List<Referral>> GetReferralsByCaregiverIdAsync(int id);
        public Task<List<ReferralRace>> GetReferralRacesByReferralId(int id);
        public Task<List<Referral>> GetReferralsFilteredAsync(DateTimeOffset? referralDateStart, DateTimeOffset? referralDateEnd, string caregiverName, string childName, int? assignedTo, List<int> referralSourceIds, int? result, int? program, bool deletedRecords);
        public Task DeleteReferral(int id, string userName);
        public Task RestoreReferral(int id, string userName);

    }
}
