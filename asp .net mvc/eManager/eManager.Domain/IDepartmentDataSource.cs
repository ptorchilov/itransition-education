namespace eManager.Domain
{
    using System.Linq;

    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; }

        IQueryable<Department> Departments { get; }
    }
}
