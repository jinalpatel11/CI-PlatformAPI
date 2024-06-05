using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CmspagesTable> CmspagesTables { get; set; }

    public virtual DbSet<CommentTable> CommentTables { get; set; }

    public virtual DbSet<ContactUsTable> ContactUsTables { get; set; }

    public virtual DbSet<DocumentTable> DocumentTables { get; set; }

    public virtual DbSet<LocalUser> LocalUsers { get; set; }

    public virtual DbSet<Mission> Missions { get; set; }

    public virtual DbSet<Story> Stories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    public virtual DbSet<VolunteeringTable> VolunteeringTables { get; set; }



}
