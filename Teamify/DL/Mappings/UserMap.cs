using System.Data.Entity.ModelConfiguration;
using Teamify.DL.Entities;

namespace Teamify.DL.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasRequired(u => u.UserProfile)
                .WithRequiredPrincipal(u => u.User);
        }
    }
}