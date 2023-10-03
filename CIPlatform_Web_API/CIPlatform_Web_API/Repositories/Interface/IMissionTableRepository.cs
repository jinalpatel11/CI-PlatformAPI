using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IMissionTableRepository
    {
        Task<IEnumerable<MissionTable>> GetMissionTable();

        Task<MissionTable> GetMissionTableById(int id);

        Task<MissionTable> AddMissionTable(MissionTable MissionTable);

        Task<MissionTable> UpdateMissionTable(MissionTable dbMissionTable, MissionTable MissionTable);

        Task DeleteMissionTable(MissionTable MissionTable);

    }
}
