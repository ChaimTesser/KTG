using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public class Hotel : Location
	{
		public int HotelID { get; set; }
		public decimal Stars { get; set; }
	}
}