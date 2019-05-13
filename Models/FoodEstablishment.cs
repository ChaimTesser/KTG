using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Models
{
	public class FoodEstablishment
	{
		public int id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		[Phone]
		public string Phone { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		public string Website { get; set; }
		public string Type { get; set; }
		public string Hechsher { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public virtual Cities CityID { get; set; }
	}
}