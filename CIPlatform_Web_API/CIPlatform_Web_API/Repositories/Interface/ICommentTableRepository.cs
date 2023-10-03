using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface ICommentTableRepository
    {
        Task<IEnumerable<CommentTable>> GetCommentTable();

        Task<CommentTable> GetCommentTableById(int id);

        Task<CommentTable> AddCommentTable(CommentTable CommentTable);

        Task<CommentTable> UpdateCommentTable(CommentTable dbCommentTable, CommentTable CommentTable);

        Task DeleteCommentTable(CommentTable CommentTable);

    }
}
