using Geocoding;
using Geocoding.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KTG.Areas.Setup.Models
{
	public sealed class Geocoder
	{
		private static volatile Geocoder instance;
		private static object syncRoot = new object();

		public static Geocoder Instance
		{
			get
			{
				if (instance == null)
				{
					lock (syncRoot)
					{
						if (instance == null)
							instance = new Geocoder();
					}
				}
				return instance;
			}
		}

		public static void Init()
		{
			Geocoder geocoder = Instance;
			Instance.IGeo = new GoogleGeocoder() { ApiKey = "AIzaSyCuokH7vVIf-FyYXtPXz8EPKnQ7bafv1Ww" };
		}

		public IGeocoder IGeo { get; set; }

	}
}