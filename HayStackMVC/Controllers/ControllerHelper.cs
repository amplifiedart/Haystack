using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace HayStackMVC.Controllers
{
	public static class ControllerHelper
	{
		public static string ConnectionString()
		{
			if (WebConfigurationManager.ConnectionStrings.Count > 0 &&
				WebConfigurationManager.ConnectionStrings["HSConnection"] != null)
				return WebConfigurationManager.ConnectionStrings["HSConnection"].ConnectionString;
			else
				throw new ApplicationException("Connection string not found!\r\nPleas check web.config.");
		}
	}
}