namespace eManager.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Domain;

    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataSource db;

        public DepartmentController(IDepartmentDataSource db)
        {
            this.db = db;
        }

        public ActionResult Detail(int id)
        {
            var model = db.Departments.Single(d => d.Id == id);

            return View(model);
        }
    }
}
