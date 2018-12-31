using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KTG.Models
{
	public class Zmanim
	{
		public int ID { get; set; }
		public virtual Shul Shul { get; set; }
		public List<string> WeekDayShachris { get; set; }
		public List<string> WeekDayMincha { get; set; }
		public List<string> WeekdayMaariv { get; set; }

	}
}