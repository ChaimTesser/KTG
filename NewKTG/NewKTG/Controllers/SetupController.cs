using KTG.Models;
using KTG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Controllers
{
	public class SetupController : Controller
	{
		KTGDb db = new KTGDb();
		// GET: Setup
		public ActionResult Index()
		{
			SetupViewModel model = new SetupViewModel();
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(SetupViewModel model)
		{
			KTGDb db = new KTGDb();
			model.Cities = db.Cities.Where(c => c.State == model.State).OrderBy(c=>c.CityName).ToList();
			return RedirectToAction("CitySetup", new { model = model });
		}

		public ActionResult CitySetup(SetupViewModel model)
		{
			if (model.State != null)
			{
				KTGDb db = new KTGDb();
				var CheckForCities = db.Cities.Where(c => c.State == model.State).ToList();
				if (CheckForCities.Count() == 0)
				{
					model.NoCities = true;
				}
				else
				{
					model.Cities = CheckForCities;
				}
				return View(model);
			}
			else
				return RedirectToAction("Index");

		}

		[HttpPost]
		public ActionResult AddCity(SetupViewModel model)
		{
			KTGDb db = new KTGDb();
			Cities newCity = new Cities()
			{
				CityName = model.CityName,
				State = model.State
			};
			db.Cities.Add(newCity);
			db.SaveChanges();
			return RedirectToAction("CitySetup", model);

		}

		public ActionResult AddShul(int id)
		{
			ShulSetupViewModel shul = new ShulSetupViewModel();
			shul.CityCode = db.Cities.Find(id).CityID;
			return View(shul);
		}

		public ActionResult AddHotel(int id)
		{
			HotelSetupViewModel model = new HotelSetupViewModel();
			model.CityCode = id;
			return View(model);
		}
	}
}