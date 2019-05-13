using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public class Shul : Location
	{
		public int ShulID { get; set; }
		public string Rabbi { get; set; }
		public string Nusach { get; set; }
		public virtual ICollection<Zman> Zmanim { get; set; } = new HashSet<Zman>();
	}
}