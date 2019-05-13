using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public class Activity : Location
	{
		public int id { get; set; }
		public string Description { get; set; }
	}
}