using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Repositories.Interface
{
    public interface IStoryTableRepository
    {
        Task<IEnumerable<StoryTable>> GetStoryTable();

        Task<StoryTable> GetStoryTableById(int id);

        Task<StoryTable> AddStoryTable(StoryTable StoryTable);

        Task<StoryTable> UpdateStoryTable(StoryTable dbStoryTable, StoryTable StoryTable);

        Task DeleteStoryTable(StoryTable StoryTable);

    }
}
