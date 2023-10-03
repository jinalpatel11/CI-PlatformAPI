using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IContactUsTableRepository
    {
        Task<IEnumerable<ContactUsTable>> GetContactUsTable();

        Task<ContactUsTable> GetContactUsTableById(int id);

        Task<ContactUsTable> AddContactUsTable(ContactUsTable ContactUsTable);

        Task<ContactUsTable> UpdateContactUsTable(ContactUsTable dbContactUsTable, ContactUsTable ContactUsTable);

        Task DeleteContactUsTable(ContactUsTable ContactUsTable);

    }
}
