namespace eManager.Domain
{
    using System.Linq;

    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; set; }

        IQueryable<Department> Departments { get; set; }
    }
}
