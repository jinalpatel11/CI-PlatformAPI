using System;
using System.Collections.Generic;
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2QFP1NN;Database=CIPlatform_API;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CmspagesTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PageDescription).IsFixedLength();
            entity.Property(e => e.PageTitle).IsFixedLength();
            entity.Property(e => e.Slug).IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();
        });

        modelBuilder.Entity<CommentTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CommentTable1).IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.CommentTables).HasConstraintName("FK_CommentTable_CommentTable");
        });

        modelBuilder.Entity<ContactUsTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EmailAddress).IsFixedLength();
            entity.Property(e => e.Message).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.Subject).IsFixedLength();
        });

        modelBuilder.Entity<DocumentTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DocumentType).IsFixedLength();
            entity.Property(e => e.DocumentValue).IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.DocumentTables).HasConstraintName("FK_DocumentTable_UserTable");
        });

        modelBuilder.Entity<Mission>(entity =>
        {
            entity.Property(e => e.MissionAvailability).IsFixedLength();
            entity.Property(e => e.MissionDescription).IsFixedLength();
            entity.Property(e => e.MissionDocumnets).IsFixedLength();
            entity.Property(e => e.MissionImages).IsFixedLength();
            entity.Property(e => e.MissionOrganisationDetail).IsFixedLength();
            entity.Property(e => e.MissionOrganisationName).IsFixedLength();
            entity.Property(e => e.MissionSkills).IsFixedLength();
            entity.Property(e => e.MissionTheme).IsFixedLength();
            entity.Property(e => e.MissionTitle).IsFixedLength();
        });

        modelBuilder.Entity<Story>(entity =>
        {
            entity.Property(e => e.StoryDescription).IsFixedLength();
            entity.Property(e => e.StoryPhoto).IsFixedLength();
            entity.Property(e => e.StoryThumbnail).IsFixedLength();
            entity.Property(e => e.StoryTitle).IsFixedLength();
            entity.Property(e => e.VideoUrl).IsFixedLength();

            entity.HasOne(d => d.Mission).WithMany(p => p.Stories).HasConstraintName("FK_Story_Story");

            entity.HasOne(d => d.User).WithMany(p => p.Stories).HasConstraintName("FK_Story_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Availability).IsFixedLength();
            entity.Property(e => e.City).IsFixedLength();
            entity.Property(e => e.Country).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Email).IsFixedLength();
            entity.Property(e => e.EmployeeId).IsFixedLength();
            entity.Property(e => e.FirstName).IsFixedLength();
            entity.Property(e => e.Image).IsFixedLength();
            entity.Property(e => e.MySkills).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.Password).IsFixedLength();
            entity.Property(e => e.PhoneNumber).IsFixedLength();
            entity.Property(e => e.ProfileSummary).IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();
            entity.Property(e => e.Surname).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.WhyIvolunteer).IsFixedLength();
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Availability).IsFixedLength();
            entity.Property(e => e.City).IsFixedLength();
            entity.Property(e => e.Country).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.FirstName).IsFixedLength();
            entity.Property(e => e.MySkills).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.Password).IsFixedLength();
            entity.Property(e => e.ProfileSummary).IsFixedLength();
            entity.Property(e => e.Surname).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.WhyIvolunteer).IsFixedLength();
        });

        modelBuilder.Entity<VolunteeringTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Hours).IsFixedLength();
            entity.Property(e => e.Minutes).IsFixedLength();
            entity.Property(e => e.Mission).IsFixedLength();
            entity.Property(e => e.Notes).IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.VolunteeringTables).HasConstraintName("FK_VolunteeringTable_UserTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
