using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Models
{
	public class Cities
	{
		[Key]
		public int CityID { get; set; }
		public string CityName { get; set; }
		public string State { get; set; }
	}
}