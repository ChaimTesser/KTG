using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Models
{
	public class FoodEstablishment : Location
	{
		public int ID { get; set; }
		public string Type { get; set; }
		public virtual Hechsher Hechsher { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
	}
}