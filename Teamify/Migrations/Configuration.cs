using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Teamify.DL;
using Teamify.DL.Entities;
using Teamify.Helpers;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Teamify.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            InitializeIdentities(context);

            InitializeSports(context);

            InitializeAddSportRequests(context);
        }

        public static void InitializeIdentities(ApplicationDbContext context)
        {

            if (!context.Users.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                // Add missing roles
                var role = roleManager.FindByName("Administrator");
                if (role == null)
                {
                    role = new IdentityRole("Administrator");
                    roleManager.Create(role);
                }

                // Create test users
                var robertUser = userManager.FindByName("robert");
                if (robertUser == null)
                {
                    var newUser = new ApplicationUser
                    {
                        UserName = "robnvd01@gmail.com",
                        Email = "robnvd01@gmail.com",
                        PhoneNumber = "0746614189",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = false
                    };
                    newUser.UserProfile = new UserProfile
                    {
                        ApplicationUser = newUser,
                        LastName = "Ursu",
                        FirstName = "Robert",
                        Bio = "Genius",
                        Rating = 5
                    };
                    newUser.UserProfile.AddAudit(newUser);

                    userManager.Create(newUser, "robertpassword");
                    userManager.SetLockoutEnabled(newUser.Id, false);
                    userManager.AddToRole(newUser.Id, "Administrator");
                }

                var beatriceUser = userManager.FindByName("beatrice");
                if (beatriceUser == null)
                {
                    var newUser = new ApplicationUser
                    {
                        UserName = "beatrisuu@gmail.com",
                        Email = "beatrisuu@gmail.com",
                        PhoneNumber = "0746614189",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = false

                    };
                    newUser.UserProfile = new UserProfile
                    {
                        ApplicationUser = newUser,
                        LastName = "Toma",
                        FirstName = "Beatrice",
                        Bio = "Genius",
                        Rating = 5
                    };
                    newUser.UserProfile.AddAudit(newUser);

                    userManager.Create(newUser, "baetricepassword");
                    userManager.SetLockoutEnabled(newUser.Id, false);
                    userManager.AddToRole(newUser.Id, "Administrator");
                }
            }
        }

        public static void InitializeSports(ApplicationDbContext context)
        {
            var createUser = context.Users.FirstOrDefault();
            var sport1 = new Sport
            {
                Name = "Fotbal",
                Description = "Descrierea fotbalului",
                Rules = "Regulile fotbalului"
            };
            sport1.AddAudit(createUser);

            var sport2 = new Sport
            {
                Name = "Baschet",
                Description = "Baschet fotbalului",
                Rules = "Regulile baschetului"
            };
            sport2.AddAudit(createUser);

            context.Sports.AddOrUpdate(x => x.Name, sport1, sport2);
        }

        public static void InitializeAddSportRequests(ApplicationDbContext context)
        {
            var createUser = context.Users.FirstOrDefault();
            var addSportRequest1 = new AddSportRequest
            {
                SportName = "Hochei",
                SportDescription = "Se joaca pe gheata",
                SportRules = "Se da cu batu in puc"
            };
            addSportRequest1.AddAudit(createUser);

            var addSportRequest2 = new AddSportRequest
            {
                SportName = "Baseball",
                SportDescription = "Se joaca cu bata",
                SportRules = "Se da cu bata in minge"
            };
            addSportRequest2.AddAudit(createUser);

            context.AddSportRequests.AddOrUpdate(x => x.SportName, addSportRequest1, addSportRequest2);
        }
    }
}
