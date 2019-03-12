using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public class Hechsher
	{
		public int id { get; set; }
		public string Name { get; set; }
		[DisplayName("Rabbi(s)")]
		public string Rabbis { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string WebSite { get; set; }
		public bool CrcApproved { get; set; }
	}
}