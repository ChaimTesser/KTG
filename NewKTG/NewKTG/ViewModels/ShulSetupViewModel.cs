﻿using KTG.Models;
using KTG.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.ViewModels
{
	public class ShulSetupViewModel
	{
		public SetupViewModel svm = new SetupViewModel();
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
		public string Nusach { get; set; }
		public int CityCode { get; set; }
	}
}