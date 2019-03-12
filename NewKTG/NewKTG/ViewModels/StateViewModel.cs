using KTG.Areas.Setup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KTG.ViewModels
{
	public class StateViewModel
	{
		public string StateName { get; set; }
		public List<Cities> Cities { get; set; }
	}
}