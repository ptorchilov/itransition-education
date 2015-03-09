﻿namespace eManager.Web.Infrastructure
{
    using System.Data.Entity;
    using System.Linq;
    using eManager.Domain;

    public class DepartmentDbcs : DbContext, IDepartmentDataSource
    {
        public DepartmentDbcs() : base("DefaultConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

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