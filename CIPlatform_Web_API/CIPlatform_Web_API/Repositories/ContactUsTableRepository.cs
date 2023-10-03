namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class ContactUsTableRepository : RepositoryBase<ContactUsTable>, IContactUsTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public ContactUsTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<ContactUsTable>> GetContactUsTable()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<ContactUsTable> GetContactUsTableById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<ContactUsTable> AddContactUsTable(ContactUsTable ContactUsTable)
        {

            this.CreateEntity(ContactUsTable);

            await this.SaveAsync();

            return ContactUsTable;
        }

        public async Task<ContactUsTable> UpdateContactUsTable(ContactUsTable dbContactUsTable, ContactUsTable ContactUsTable)
        {
            dbContactUsTable.Map(ContactUsTable);
            this.UpdateEntity(dbContactUsTable);

            await this.SaveAsync();
            return dbContactUsTable;
        }

        public async Task DeleteContactUsTable(ContactUsTable ContactUsTable)
        {
            this.DeleteEntity(ContactUsTable);

            await this.SaveAsync();
        }

    }
}

