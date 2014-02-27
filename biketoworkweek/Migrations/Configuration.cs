namespace biketoworkweeklogger.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using biketoworkweeklogger.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<biketoworkweeklogger.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        bool AddUserAndRole(biketoworkweeklogger.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            ir = rm.Create(new IdentityRole("CanEdit"));

            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser()
            {
                UserName = "user1",
            };

            ir = um.Create(user, "123456");
            if (ir.Succeeded == false)
                return ir.Succeeded;

            ir = um.AddToRole(user.Id, "CanEdit");

            return ir.Succeeded;
        }

        protected override void Seed(biketoworkweeklogger.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            this.AddUserAndRole(context);

            context.Teams.AddOrUpdate(p => p.Name,
                                new Team
                                {
                                    Name = "Team1",
                                    Created = DateTime.Now,
                                    Modified = DateTime.Now,
                                    ModifiedBy = "bensonius",

                                }
                            );

            context.Riders.AddOrUpdate(r => r.Email,
                    new Rider
                    {
                        Email = "bensonlott@gmail.com",
                        FirstName = "Benson",
                        LastName = "Lott",
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        ModifiedBy = "bensonius",
                        TeamID = 1,
                        UserID = new Guid("2b575e2a-6448-4c23-904d-c28f286262a4")
                    }
                );
        }
    }
}
