using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Models
{
	public class FoodEstablishment
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
		public string Type { get; set; }
		public virtual Hechsher Hechsher { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public virtual Cities IDCity { get; set; }
		
	}
}