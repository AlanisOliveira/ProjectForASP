using System.Reflection;
using System.Collections.Generic;
using ProjectAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace ProjectAPI.Infrastructure.Persistence
{
    public class ProjectDbContext : DbContext
    {
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
           
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            
            
            

            
        }
    }
}