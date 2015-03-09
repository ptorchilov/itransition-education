namespace eManager.Web.Controllers
{
    using System.Web.Mvc;
    using eManager.Domain;
    using eManager.Web.Infrastructure;

    public class HomeController : Controller
    {
        private IDepartmentDataSource db = new DepartmentDbcs();

        public ActionResult Index()
        {
            var allDepartments = db.Departments;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
