namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class DocumentTableRepository : RepositoryBase<DocumentTable>, IDocumentTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public DocumentTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<DocumentTable>> GetDocumentTable()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<DocumentTable> GetDocumentTableById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<DocumentTable> AddDocumentTable(DocumentTable DocumentTable)
        {

            this.CreateEntity(DocumentTable);

            await this.SaveAsync();

            return DocumentTable;
        }

        public async Task<DocumentTable> UpdateDocumentTable(DocumentTable dbDocumentTable, DocumentTable DocumentTable)
        {
            dbDocumentTable.Map(DocumentTable);
            this.UpdateEntity(dbDocumentTable);

            await this.SaveAsync();
            return dbDocumentTable;
        }

        public async Task DeleteDocumentTable(DocumentTable DocumentTable)
        {
            this.DeleteEntity(DocumentTable);

            await this.SaveAsync();
        }

    }
}

