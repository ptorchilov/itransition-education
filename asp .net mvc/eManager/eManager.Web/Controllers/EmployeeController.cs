namespace eManager.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Domain;
    using Models;

    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource db;

        public EmployeeController(IDepartmentDataSource db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel
            {
                Department = departmentId
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = db.Departments.Single(d => d.Id == viewModel.Department);

                var employee = new Employee
                {
                    Name = viewModel.Name,
                    HireDate = viewModel.HireDate
                };

                department.Employees.Add(employee);

                db.Save();

                return RedirectToAction("Detail", "Department", new { id = viewModel.Department });
            }

            return View(viewModel);
        }
    }
}