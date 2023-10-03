using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IDocumentTableRepository
    {
        Task<IEnumerable<DocumentTable>> GetDocumentTable();

        Task<DocumentTable> GetDocumentTableById(int id);

        Task<DocumentTable> AddDocumentTable(DocumentTable DocumentTable);

        Task<DocumentTable> UpdateDocumentTable(DocumentTable dbDocumentTable, DocumentTable DocumentTable);

        Task DeleteDocumentTable(DocumentTable DocumentTable);

    }
}
