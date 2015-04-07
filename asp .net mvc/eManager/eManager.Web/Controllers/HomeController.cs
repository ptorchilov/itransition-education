namespace eManager.Web.Controllers
{
    using System.Web.Mvc;
    using Domain;
    
    public class HomeController : Controller
    {
        private readonly IDepartmentDataSource db;

        public HomeController(IDepartmentDataSource db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var allDepartments = db.Departments;

            return View(allDepartments);
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
