using KTG.Models;
using KTG.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
		public string Rabbi { get; set; }
		public string Nusach { get; set; }
		public string OtherNusach { get; set; }
		public int CityCode { get; set; }

		public SelectList NusachSelector()
		{
			List<SelectListItem> lst = new List<SelectListItem>()
				{
					new SelectListItem() { Text="Ashkenaz", Value="Ashkenaz"},
					new SelectListItem() { Text="Sefard", Value="Sefard"},
					new SelectListItem() { Text="Edut Hamizrach", Value="Edut Hamizrach"},
					new SelectListItem() { Text="Ari", Value="Ari"},
					new SelectListItem() { Text="Other", Value="Other"}
			};
			return new SelectList(lst, "Value", "Text");
		}
	}
}