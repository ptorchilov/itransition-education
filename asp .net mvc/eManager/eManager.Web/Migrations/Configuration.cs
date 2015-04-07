namespace eManager.Web.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Web.Security;
    using Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.DepartmentDbcs>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Infrastructure.DepartmentDbcs context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department { Name = "Engineering" },
                new Department { Name = "Sales" },
                new Department { Name = "Shipping" },
                new Department { Name = "Human Resources"}
            );

            if (!Roles.RoleExists("Admin"))
            {
                Roles.CreateRole("Admin");
            }

            if (Membership.GetUser("sallen") == null)
            {
                Membership.CreateUser("sallen", "123");
                Roles.AddUserToRole("sallen", "Admin");
            }
        }
    }
}
