using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.BusinessLogic.Facade
{
	public class SystemInfo
	{
		public int AmountOfDocuments { get { return 200; } }

		public DateTime FirstScan { get { return DateTime.Parse("1-Jan-2018"); } }
	}
}
