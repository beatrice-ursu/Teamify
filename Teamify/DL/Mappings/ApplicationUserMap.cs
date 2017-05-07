using System.Data.Entity.ModelConfiguration;
using Teamify.DL.Entities;

namespace Teamify.DL.Mappings
{
    public class ApplicationUserMap : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMap()
        {
            this.HasRequired(u => u.UserProfile)
                .WithRequiredPrincipal(u => u.ApplicationUser);
        }
    }
}