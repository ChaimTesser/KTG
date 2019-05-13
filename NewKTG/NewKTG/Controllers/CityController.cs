using Geocoding;
using Geocoding.Google;
using KTG.Areas.Setup.Models;
using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Controllers
{
    public class CityController : Controller
    {
		Db db = new Db();
        // GET: City
        public ActionResult Index()
        {
            return View();
        }

		public async System.Threading.Tasks.Task<ActionResult> ViewCityDetails(int id)
		{
			Cities city = db.Cities.Find(id);
			IGeocoder geocoder = Geocoder.Instance.IGeo;
			IEnumerable<Address> addresses = await geocoder.GeocodeAsync(city.CityName + ", " + city.State);
			if (city.Coordinates == null)
				city.Coordinates = new Coordinates();
			city.Coordinates.Longitude = addresses.FirstOrDefault().Coordinates.Longitude;
			city.Coordinates.Latitude = addresses.FirstOrDefault().Coordinates.Latitude;
			return View(city);
		}
    }
}