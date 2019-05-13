using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Controllers
{
    public class FoodEstablishmentController : Controller
    {
		Db db = new Db();
        // GET: FoodEstablishment
        public ActionResult Index(int CityID = 0)
        {
			if (CityID == 0)
				return View(db.FoodEstablishments.ToList());
			else
				return View(db.FoodEstablishments.Where(f => f.CityID.CityID == CityID));
        }

		public ActionResult AddNew()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AddNew(FoodEstablishment F)
		{
			db.FoodEstablishments.Add(F);
			db.SaveChanges();
			return null;
		}

		public ActionResult Edit(int id)
		{
			FoodEstablishment f = db.FoodEstablishments.Find(id);
			return View(f);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(FoodEstablishment f)
		{
			db.Entry(f).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			return View(db.FoodEstablishments.Find(id));
		}
    }
}