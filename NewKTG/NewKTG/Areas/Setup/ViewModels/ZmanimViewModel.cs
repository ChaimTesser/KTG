using KTG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.ViewModels
{
	public class ZmanimViewModel
	{
		//public List<Zman> Zman { get; set; }
		public string Time { get; set; }
		public int ShulID { get; set; }
		[DisplayName("Custom Time")]
		public string OtherTime { get; set; }
		public string Days { get; set; }
		public string OtherDay { get; set; }
		public string Prayer { get; set; }

		public SelectList DaySelector()
		{
			List<SelectListItem> lst = new List<SelectListItem>()
				{
					new SelectListItem() { Text="Sunday", Value="Sunday"},
					new SelectListItem() { Text="Monday", Value="Monday"},
					new SelectListItem() { Text="Tuesday", Value="Tuesday"},
					new SelectListItem() { Text="Wednesday", Value="Wednesday"},
					new SelectListItem() { Text="Thursday", Value="Thursday"},
					new SelectListItem() { Text="Friday", Value="Friday"},
					new SelectListItem() { Text="Shabbos", Value="Shabbos"},
					new SelectListItem() { Text="Motzei Shabbos", Value="Motzei Shabbos"},
					new SelectListItem() { Text="Sun - Fri", Value="Sun - Fri"},
					new SelectListItem() { Text="Sun - Thu", Value="Sun - Thu"},
					new SelectListItem() { Text="Mon - Thu", Value="Mon - Thu"},
					new SelectListItem() { Text="Mon & Thu", Value="Mon & Thu"},
					new SelectListItem() { Text="Tue & Wed", Value="Tue & Wed"}
			};
					return new SelectList(lst, "Value", "Text");
		}

		public SelectList PrayerSelector()
		{
			List<SelectListItem> lst = new List<SelectListItem>()
				{
					new SelectListItem() { Text="Shacharis", Value="Shacharis"},
					new SelectListItem() { Text="Mincha", Value="Mincha"},
					new SelectListItem() { Text="Maariv", Value="Maariv"},
					new SelectListItem() { Text="Mincha/Maariv", Value="Mincha/Maariv"}
			};
			return new SelectList(lst, "Value", "Text");
		}

	}
}