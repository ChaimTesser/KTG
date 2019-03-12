using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public class Cities
	{
		[Key]
		public int CityID { get; set; }
		public string CityName { get; set; }
		public string State { get; set; }
		public virtual ICollection<Shul> Shuls { get; set; } = new HashSet<Shul>();
		public virtual ICollection<Activity> Activities { get; set; } = new HashSet<Activity>();
		public virtual ICollection<Hotel> Hotels { get; set; } = new HashSet<Hotel>();
		public virtual ICollection<FoodEstablishment> FoodEstablishments { get; set; } = new HashSet<FoodEstablishment>();
		[NotMapped]
		public string longi { get; set; }
		[NotMapped]
		public string latit { get; set; }
	}
}