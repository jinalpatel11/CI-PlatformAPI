using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IMissionTableRepository
    {
        Task<IEnumerable<Mission>> GetMissionTable();

        Task<Mission> GetMissionTableById(int id);

        Task<Mission> AddMissionTable(Mission MissionTable);

        Task<Mission> UpdateMissionTable(Mission dbMissionTable, Mission MissionTable);

        Task DeleteMissionTable(Mission MissionTable);

    }
}
