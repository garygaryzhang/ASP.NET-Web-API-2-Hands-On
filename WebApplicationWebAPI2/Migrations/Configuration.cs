namespace WebApplicationWebAPI2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplicationWebAPI2.Models.WebApplicationWebAPI2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplicationWebAPI2.Models.WebApplicationWebAPI2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Contacts.AddOrUpdate( new Contact[] {
              new Contact { Id = 0, FirstName = "Andrew Peters", LastName = "Peters" },
              new Contact { Id = 1, FirstName = "Brice Lambson", LastName = "Lambson" },
              new Contact { Id = 2, FirstName = "Rowan Miller", LastName = "Miller" }
            });

        }
    }
}
