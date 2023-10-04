namespace CIPlatform_Web_API.Repositories
{
    using CIPlatform_Web_API.Infrastructure;
    using CIPlatform_Web_API.Repositories.Interface;
    using Microsoft.EntityFrameworkCore;

    public class UserTableRepository : RepositoryBase<User>, IUserTableRepository
    {
        private readonly ApplicationDbContext calistaContext;

        public UserTableRepository(ApplicationDbContext calistaContext)
        : base(calistaContext)
        {
            this.calistaContext = calistaContext;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await this.Find()
            .OrderByDescending(a => a.Id)
            .ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await this.Find(d => d.Id == id)
            .SingleOrDefaultAsync();
        }

        public async Task<User> AddUser(User user)
        {

            this.CreateEntity(user);

            await this.SaveAsync();

            return user;
        }

        public async Task<User> UpdateUser(User dbUser, User user)
        {
            user.Id = dbUser.Id;


            dbUser.Map(user);
            this.UpdateEntity(dbUser);

            await this.SaveAsync();
            return dbUser;
        }

        public async Task DeleteUser(User user)
        {
            this.DeleteEntity(user);

            await this.SaveAsync();
        }

    }

}
