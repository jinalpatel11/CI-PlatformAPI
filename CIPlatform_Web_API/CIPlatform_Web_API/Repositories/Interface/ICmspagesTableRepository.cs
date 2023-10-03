using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface ICmspagesTableRepository
    {
        Task<IEnumerable<CmspagesTable>> GetCmspagesTable();

        Task<CmspagesTable> GetCmspagesTableById(int id);

        Task<CmspagesTable> AddCmspagesTable(CmspagesTable CmspagesTable);

        Task<CmspagesTable> UpdateCmspagesTable(CmspagesTable dbCmspagesTable, CmspagesTable CmspagesTable);

        Task DeleteCmspagesTable(CmspagesTable CmspagesTable);
    }
}
