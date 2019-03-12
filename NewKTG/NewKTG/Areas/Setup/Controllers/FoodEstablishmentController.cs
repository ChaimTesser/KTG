using KTG.Areas.Setup.Models;
using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Controllers
{
    public class FoodEstablishmentController : Controller
    {
		Db db = new Db();
        // GET: FoodEstablishment
        public ActionResult Index(int id)
        {
			if (id == null || id == 0)
				return View(db.FoodEstablishments.ToList());
			else
				return View(db.FoodEstablishments.Where(f => f.IDCity.CityID == id));
        }

		public ActionResult AddNew(int id)
		{
			FoodEstablishment f = new FoodEstablishment();
			f.IDCity = db.Cities.Find(id);
			return View(f);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AddNew(FoodEstablishment F)
		{
			F.IDCity = db.Cities.Find(F.IDCity.CityID);
			F.Hechsher = db.Hechshers.Find(F.Hechsher.id);
			db.FoodEstablishments.Add(F);
			db.SaveChanges();
			return RedirectToAction("Index", new { id = F.IDCity.CityID });
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
			return RedirectToAction("Index", new { id = f.IDCity.CityID });
		}

		public ActionResult Details(int id)
		{
			var model = db.FoodEstablishments.Find(id);
			return View(db.FoodEstablishments.Find(id));
		}

		public ActionResult Delete(int id)
		{
			var del = db.FoodEstablishments.Find(id);
			var cid = del.IDCity.CityID;
			db.FoodEstablishments.Remove(del);
			db.SaveChanges();
			return RedirectToAction("Index", new { id = cid });
		}
    }
}