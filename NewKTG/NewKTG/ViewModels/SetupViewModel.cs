using KTG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.ViewModels
{
	public class SetupViewModel
	{
		public string State { get; set; }
		[DisplayName("City Name")]
		public string CityName { get; set; }
		public List<Cities> Cities { get; set; }
		public bool NoCities { get; set; }
		public SelectList GetCitiesSelector()
		{
			var x = Cities.Select(pr => new SelectListItem { Text = pr.CityName, Value = pr.CityID.ToString() }).ToList();

			return new SelectList(x
				, "Value", "Text");
		}
		public SelectList GetStateSelector()
		{
			List<SelectListItem> lst = new List<SelectListItem>()
				{
					new SelectListItem() { Text="Alabama", Value="AL"},
					//new SelectListItem() { Text="Alberta", Value="AB"},
					new SelectListItem() { Text="Alaska", Value="AK"},
					new SelectListItem() { Text="Arizona", Value="AZ"},
					new SelectListItem() { Text="Arkansas", Value="AR"},
					//new SelectListItem() { Text="AP",Value= "AP" },
					//new SelectListItem() { Text="British Columbia", Value="BC"},
					new SelectListItem() { Text="California", Value="CA"},
					new SelectListItem() { Text="Colorado", Value="CO"},
					new SelectListItem() { Text="Connecticut", Value="CT"},
					new SelectListItem() { Text="District of Columbia", Value="DC"},
					new SelectListItem() { Text="Delaware", Value="DE"},
					new SelectListItem() { Text="Florida", Value="FL"},
					new SelectListItem() { Text="Georgia", Value="GA"},
					new SelectListItem() { Text="Hawaii", Value="HI"},
					new SelectListItem() { Text="Idaho", Value="ID"},
					new SelectListItem() { Text="Illinois", Value="IL"},
					new SelectListItem() { Text="Indiana", Value="IN"},
					new SelectListItem() { Text="Iowa", Value="IA"},
					new SelectListItem() { Text="Kansas", Value="KS"},
					new SelectListItem() { Text="Kentucky", Value="KY"},
					new SelectListItem() { Text="Louisiana", Value="LA"},
					new SelectListItem() { Text="Maine", Value="ME"},
					//new SelectListItem() {Text="Manitoba", Value="MB"},
					new SelectListItem() { Text="Maryland", Value="MD"},
					new SelectListItem() { Text="Massachusetts", Value="MA"},
					new SelectListItem() { Text="Michigan", Value="MI"},
					new SelectListItem() { Text="Minnesota", Value="MN"},
					new SelectListItem() { Text="Mississippi", Value="MS"},
					new SelectListItem() { Text="Missouri", Value="MO"},
					new SelectListItem() { Text="Montana", Value="MT"},
					new SelectListItem() { Text="Nebraska", Value="NE"},
					new SelectListItem() { Text="Nevada", Value="NV"},
					//new SelectListItem() {Text="New Brunswick", Value="NB"},
					//new SelectListItem() {Text="Newfoundland", Value="NL"},
					new SelectListItem() { Text="New Hampshire", Value="NH"},
					new SelectListItem() { Text="New Jersey", Value="NJ"},
					new SelectListItem() { Text="New Mexico", Value="NM"},
					new SelectListItem() { Text="New York", Value="NY"},
					//new SelectListItem() {Text="Northwest Territories", Value="NT"},
					new SelectListItem() { Text="North Carolina", Value="NC"},
					new SelectListItem() { Text="North Dakota", Value="ND"},
					//new SelectListItem() {Text="Nova Scotia", Value="NS"},
					//new SelectListItem() {Text="Nunavut", Value="NU"},
					new SelectListItem() { Text="Ohio", Value="OH"},
					new SelectListItem() { Text="Oklahoma", Value="OK"},
					//new SelectListItem() {Text="Ontario", Value="ON"},
					new SelectListItem() { Text="Oregon", Value="OR"},
					new SelectListItem() { Text="Pennsylvania", Value="PA"},
					//new SelectListItem() {Text="Prince Edward Island", Value="PE"},
					//new SelectListItem() {Text="Quebec", Value="QC"},
					new SelectListItem() { Text="Rhode Island", Value="RI"},
					//new SelectListItem() {Text="Saskatchewan", Value="SK"},
					new SelectListItem() { Text="South Carolina", Value="SC"},
					new SelectListItem() { Text="South Dakota", Value="SD"},
					new SelectListItem() { Text="Tennessee", Value="TN"},
					new SelectListItem() { Text="Texas", Value="TX"},
					new SelectListItem() { Text="Utah", Value="UT"},
					new SelectListItem() { Text="Vermont", Value="VT"},
					new SelectListItem() { Text="Virginia", Value="VA"},
					new SelectListItem() { Text="Washington", Value="WA"},
					new SelectListItem() { Text="West Virginia", Value="WV"},
					new SelectListItem() { Text="Wisconsin", Value="WI"},
					new SelectListItem() { Text="Wyoming", Value="WY"}
					//new SelectListItem() {Text="Yukon", Value="YT"}
				};
			if (State == "" || State == null)
				return new SelectList(lst, "Value", "Text");
			else
				return new SelectList(lst, "Value", "Text", State);
		}
	}
}