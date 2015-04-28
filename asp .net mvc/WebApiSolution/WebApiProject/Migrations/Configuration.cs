namespace WebApiProject.Migrations
{
    using System.Data.Entity.Migrations;
    using WebApiProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiProject.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Models.VideoDb context)
        {
            context.Videos.AddOrUpdate(v => v.Title,
                new Video { Title = "MVC4", Length = 120 },
                new Video { Title = "LINQ", Length = 200 }
            );

            context.SaveChanges();
        }
    }
}
