namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class CommentTableRepository : RepositoryBase<CommentTable>, ICommentTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public CommentTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<CommentTable>> GetCommentTable()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<CommentTable> GetCommentTableById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<CommentTable> AddCommentTable(CommentTable ContactUsTable)
        {

            this.CreateEntity(ContactUsTable);

            await this.SaveAsync();

            return ContactUsTable;
        }

        public async Task<CommentTable> UpdateCommentTable(CommentTable dbCommentTable, CommentTable CommentTable)
        {
            dbCommentTable.Map(CommentTable);
            this.UpdateEntity(dbCommentTable);

            await this.SaveAsync();
            return dbCommentTable;
        }

        public async Task DeleteCommentTable(CommentTable CommentTable)
        {
            this.DeleteEntity(CommentTable);

            await this.SaveAsync();
        }

    }
}

