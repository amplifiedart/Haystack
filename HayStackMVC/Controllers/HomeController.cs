using HS.BusinessLogic;
using HS.BusinessLogic.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayStackMVC.Controllers
{
    public class HomeController : Controller
    {
		HSLogic logic;

		public HomeController()
		{
			logic = new HSLogic(ControllerHelper.ConnectionString());
		}
        // GET: Home
        public ActionResult Index()
        {
			SystemInfo info = logic.GetSystemInfo();

            return View(info);
        }

		public ActionResult About()
		{
			return View();
		}
    }
}