using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IStoryTableRepository
    {
        Task<IEnumerable<Story>> GetStoryTable();

        Task<Story> GetStoryTableById(int id);

        Task<Story> AddStoryTable(Story StoryTable);

        Task<Story> UpdateStoryTable(Story dbStoryTable, Story StoryTable);

        Task DeleteStoryTable(Story StoryTable);

    }
}
