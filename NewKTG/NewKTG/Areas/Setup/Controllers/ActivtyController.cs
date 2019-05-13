using Geocoding;
using KTG.Areas.Setup.Models;
using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Controllers
{
	public class ActivityController : Controller
	{
		Db db = new Db();
		// GET: Activty
		public ActionResult Index(int CityId = 0)
		{
			if (CityId == 0)
				return View(db.Activities.ToList());
			else
				return View(db.Activities.Where(f => f.IDCity.CityID == CityId));
		}

		public ActionResult AddActivity(int id)
		{
			Activity a = new Activity
			{
				IDCity = db.Cities.Find(id)
			};
			return View(a);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async System.Threading.Tasks.Task<ActionResult> AddActivity(Activity a)
		{
		  	a.IDCity = db.Cities.Find(a.IDCity.CityID);
			a.Coordinates = await new Coordinates().GetCoordinates(a.Address, a.City, a.State, a.Zip);
			db.Activities.Add(a);
			db.SaveChanges();
			return RedirectToAction("Index", new { id = a.IDCity.CityID });
		}

		public ActionResult Edit(int id)
		{
			return View(db.Activities.Find(id));
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Activity a)
		{
			db.Entry(a).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index", new { id = a.IDCity.CityID });
		}

		public ActionResult Details(int id)
		{
			return View(db.Activities.Find(id));
		}

		public ActionResult Delete(int id)
		{
			Activity a = db.Activities.Find(id);
			int cityID = a.IDCity.CityID;
			db.Activities.Remove(db.Activities.Find(id));
			db.SaveChanges();
			return RedirectToAction("index", new { id = cityID });
		}
    }
}