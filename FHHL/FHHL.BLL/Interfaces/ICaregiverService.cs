using FHHL.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FHHL.BLL.Interfaces
{
    public interface ICaregiverService
    {
        public Task<Caregiver> GetCaregiverByIdAsync(int id);
        public Task<bool> CheckForCaregiverByNameAndDoB(string firstName, string lastName, DateTimeOffset doB);
        public Task CreateCaregiver(Caregiver caregiver, List<int> raceIds);
        public Task EditCaregiver(Caregiver newCaregiver, List<int> selectedRaces);
        public Task<List<CaregiverRace>> GetCaregiverRacesByCaregiverId(int id);
        public Task<List<Caregiver>> GetCaregiversFilteredAsync(DateTimeOffset? referralDateStart, DateTimeOffset? referralDateEnd, string caregiverName, string childName, int? assignedTo, DateTimeOffset? dateOfBirth);
        public Task DeleteCaregiver(int id, string userName);
        public Task RestoreCaregiver(int id, string userName);

    }
}
