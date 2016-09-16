using System.Web.Mvc;

namespace Template.Home {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
    }
}