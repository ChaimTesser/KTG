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
		Db db = new Db();
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
			Db db = new Db();
			model.Cities = db.Cities.Where(c => c.State == model.State).OrderBy(c=>c.CityName).ToList();
			return RedirectToAction("CitySetup", new { model = model });
		}

		public ActionResult CitySetup(SetupViewModel model)
		{
			if (model.State != null)
			{
				Db db = new Db();
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
			Db db = new Db();
			Cities newCity = new Cities()
			{
				CityName = model.CityName,
				State = model.State
			};
			db.Cities.Add(newCity);
			db.SaveChanges();
			return RedirectToAction("CitySetup", model);

		}

		

		

		
	}
}