namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class StoryTableRepository : RepositoryBase< Story>, IStoryTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public StoryTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<Story>> GetStoryTable()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<Story> GetStoryTableById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<Story> AddStoryTable(Story StoryTable)
        {

            this.CreateEntity(StoryTable);

            await this.SaveAsync();

            return StoryTable;
        }

        public async Task<Story> UpdateStoryTable(Story dbStoryTable, Story StoryTable)
        {
            dbStoryTable.Map(StoryTable);
            this.UpdateEntity(dbStoryTable);

            await this.SaveAsync();
            return dbStoryTable;
        }

        public async Task DeleteStoryTable(Story StoryTable)
        {
            this.DeleteEntity(StoryTable);

            await this.SaveAsync();
        }

    }
}

