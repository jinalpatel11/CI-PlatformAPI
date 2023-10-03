using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IVolunteeringTableRepository
    {
        Task<IEnumerable<VolunteeringTable>> GetVolunteeringData();

        Task<VolunteeringTable> GetVolunteeringDataById(int id);

        Task<VolunteeringTable> AddVolunteeringData(VolunteeringTable VolunteeringTable);

        Task<VolunteeringTable> UpdateVolunteeringData(VolunteeringTable dbVolunteeringTable, VolunteeringTable VolunteeringTable);

        Task DeleteVolunteeringData(VolunteeringTable VolunteeringTable);
    }
}
