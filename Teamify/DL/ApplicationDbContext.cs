using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Teamify.DL.Entities;
using Teamify.DL.Mappings;

namespace Teamify.DL
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext() : base("TeamifyDB", throwIfV1Schema: false) { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<AddSportRequest> AddSportRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicationUserMap());
            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}