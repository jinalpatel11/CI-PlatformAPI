namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class CmspagesTableRepository : RepositoryBase<CmspagesTable>, ICmspagesTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public CmspagesTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<CmspagesTable>> GetCmspagesTable()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<CmspagesTable> GetCmspagesTableById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<CmspagesTable> AddCmspagesTable(CmspagesTable CmspagesTable)
        {

            this.CreateEntity(CmspagesTable);

            await this.SaveAsync();

            return CmspagesTable;
        }

        public async Task<CmspagesTable> UpdateCmspagesTable(CmspagesTable dbCmspagesTable, CmspagesTable CmspagesTable)
        {
            dbCmspagesTable.Map(CmspagesTable);
            this.UpdateEntity(dbCmspagesTable);

            await this.SaveAsync();
            return dbCmspagesTable;
        }

        public async Task DeleteCmspagesTable(CmspagesTable CmspagesTable)
        {
            this.DeleteEntity(CmspagesTable);

            await this.SaveAsync();
        }

    }
}

