﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public abstract class Location
	{
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
		public virtual Cities IDCity { get; set; }
		public virtual Coordinates Coordinates { get; set; }
	}
}