namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class VolunteeringTableRepository : RepositoryBase<VolunteeringTable>, IVolunteeringTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public VolunteeringTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<VolunteeringTable>> GetVolunteeringData()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<VolunteeringTable> GetVolunteeringDataById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<VolunteeringTable> AddVolunteeringData(VolunteeringTable VolunteeringTable)
        {

            this.CreateEntity(VolunteeringTable);

            await this.SaveAsync();

            return VolunteeringTable;
        }

        public async Task<VolunteeringTable> UpdateVolunteeringData(VolunteeringTable dbVolunteeringTable, VolunteeringTable VolunteeringTable)
        {
            dbVolunteeringTable.Map(VolunteeringTable);
            this.UpdateEntity(dbVolunteeringTable);

            await this.SaveAsync();
            return dbVolunteeringTable;
        }

        public async Task DeleteVolunteeringData(VolunteeringTable VolunteeringTable)
        {
            this.DeleteEntity(VolunteeringTable);

            await this.SaveAsync();
        }

    }
}

