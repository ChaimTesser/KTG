using KTG.Areas.Setup.Models;
using KTG.Areas.Setup.ViewModels;
using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Controllers
{
    public class HotelController : Controller
    {
		Db db = new Db();
		public ActionResult AddHotel(int id)
		{
			HotelSetupViewModel model = new HotelSetupViewModel();
			model.CityCode = id;
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AddHotel(HotelSetupViewModel model)
		{
			Hotel hotel = new Hotel()
			{
				Name = model.Name,
				Address = model.Address,
				City = model.City,
				State = model.State,
				Zip = model.Zip,
				IDCity = db.Cities.Find(model.CityCode),
				Website = model.Website,
				Phone = model.Phone,
				Stars = model.Stars,
				Email = model.Email
			};
			db.Hotels.Add(hotel);
			db.SaveChanges();
			return RedirectToAction("AllHotels", new { id = model.CityCode });
		}

		public ActionResult AllHotels(int id)
		{
			var HotelList = db.Hotels.Where(h => h.IDCity.CityID == id).ToList();
			if (HotelList.Count() == 0)
			{
				Hotel h = new Hotel()
				{
					IDCity = db.Cities.Find(id)
				};
				HotelList.Add(h);
			}
			return View(HotelList);
		}

		public ActionResult EditHotel(int id)
		{
			Hotel hotel = db.Hotels.Find(id);
			return View(hotel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult EditHotel(Hotel hotel)
		{
			Hotel h = db.Hotels.Find(hotel.HotelID);
			h.Address = hotel.Address;
			h.City = hotel.City;
			h.IDCity = hotel.IDCity;
			h.Country = hotel.Country;
			h.Email = hotel.Email;
			h.Name = hotel.Name;
			h.Phone = hotel.Phone;
			h.Stars = hotel.Stars;
			h.Stars = hotel.Stars;
			h.Website = hotel.Website;
			h.Zip = hotel.Zip;
			db.SaveChanges();
			return RedirectToAction("AllHotels", new { id = hotel.IDCity.CityID });
		}

		public ActionResult Delete(int id)
		{
			Hotel h = db.Hotels.Find(id);
			int cityID = h.IDCity.CityID;
			db.Hotels.Remove(db.Hotels.Find(id));
			db.SaveChanges();
			return RedirectToAction("AllHotels", new { id = cityID });

		}

		public ActionResult Details(int id)
		{
			return View(db.Hotels.Find(id));
		}

	}
}