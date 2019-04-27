using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HS.BusinessLogic.Facade;
using HS.Model;

namespace HS.BusinessLogic
{
	public class HSLogic
	{
		private string v;

		public HSLogic(string v)
		{
			this.v = v;
		}

		public List<HSDocument> GetDocuments()
		{
			return new List<HSDocument>();
		}

		public SystemInfo GetSystemInfo()
		{
			return new SystemInfo();
		}
	}
}
