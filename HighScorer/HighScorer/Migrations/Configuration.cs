namespace HighScorer.Migrations
{
    using HighScorer.Backend.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HighScorer.Backend.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HighScorer.Backend.GameContext context)
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
            var links = new Link{Name="Default", Url = "/bowling"};
            var bowling = new Game
            {
                Name = "Bowling",
                Links = new List<Link> { links }
            };
            context.Links.RemoveRange(context.Links);
            context.Links.AddOrUpdate(l => l.Url, links);
            context.Games.AddOrUpdate(g => g.Name, bowling);
        }
    }
}
