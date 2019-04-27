using HS.BusinessLogic;
using HS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayStackMVC.Controllers
{
    public class DocumentController : Controller
    {
		HSLogic logic;

		public DocumentController()
		{
			logic = new HSLogic(ControllerHelper.ConnectionString());
		}

        // GET: Document
        public ActionResult Index()
        {
			List<HSDocument> result = logic.GetDocuments();
            return View(result);
        }

		public ActionResult Create()
		{
			HSDocument result = new HSDocument();
			return View(result);
		}
    }
}