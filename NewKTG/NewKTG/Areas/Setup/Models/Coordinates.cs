using Geocoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KTG.Areas.Setup.Models
{

	public class Coordinates
	{
		public int ID { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
		
		public async Task<Coordinates> GetCoordinates(string address, string city, string state, string zip)
		{
			IGeocoder geocoder = Geocoder.Instance.IGeo;
			IEnumerable<Address> addresses = await geocoder.GeocodeAsync(string.Format("{0} {1}, {2} {3}", address, city, state, zip));
			Coordinates c = new Coordinates
			{
				Longitude = addresses.First().Coordinates.Longitude,
				Latitude = addresses.First().Coordinates.Latitude
			};
			return c;
		}

	
	}
}