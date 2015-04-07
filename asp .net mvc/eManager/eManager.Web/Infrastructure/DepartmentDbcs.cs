namespace eManager.Web.Infrastructure
{
    using System.Data.Entity;
    using System.Linq;
    using Domain;

    public class DepartmentDbcs : DbContext, IDepartmentDataSource
    {
        public DepartmentDbcs() : base("DefaultConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        void IDepartmentDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get { return Departments; }
        }
    }
}