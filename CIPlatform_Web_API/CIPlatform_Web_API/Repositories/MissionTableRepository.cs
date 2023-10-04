using CIPlatform_Web_API.Infrastructure;
using CIPlatform_Web_API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Repositories
{
  
    public class MissionTableRepository : RepositoryBase<Mission>, IMissionTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public MissionTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<Mission>> GetMissionTable()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<Mission> GetMissionTableById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<Mission> AddMissionTable(Mission MissionTable)
        {

            this.CreateEntity(MissionTable);

            await this.SaveAsync();

            return MissionTable;
        }

        public async Task<Mission> UpdateMissionTable(Mission dbMissionTable, Mission MissionTable)
        {
            MissionTable.Id = dbMissionTable.Id;


            dbMissionTable.Map(MissionTable);
            this.UpdateEntity(dbMissionTable);

            await this.SaveAsync();
            return dbMissionTable;
        }

        public async Task DeleteMissionTable(Mission MissionTable)
        {
            this.DeleteEntity(MissionTable);

            await this.SaveAsync();
        }

    }

}
