using KTG.Areas.Setup.Models;
using KTG.Areas.Setup.ViewModels;
using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Controllers
{
    public class ShulController : Controller
    {
		Db db = new Db();
		public ActionResult AddShul(int id)
		{
			ShulSetupViewModel shul = new ShulSetupViewModel();
			shul.CityCode = db.Cities.Find(id).CityID;
			return View(shul);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AddShul(ShulSetupViewModel model)
		{
			Shul shul = new Shul()
			{
				Name = model.Name,
				Address = model.Address,
				City = model.City,
				State = model.State,
				Zip = model.Zip,
				IDCity = db.Cities.Find(model.CityCode),
				Website = model.Website,
				Phone = model.Phone,
				Rabbi = model.Rabbi,
				Email = model.Email
			};
			if (model.OtherNusach == null)
				shul.Nusach = model.Nusach;
			else
				shul.Nusach = model.OtherNusach;
			db.Shuls.Add(shul);
			db.SaveChanges();
			return RedirectToAction("AllShuls", new { id = model.CityCode });
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult EditShul(Shul shul)
		{
			db.Entry(shul).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("AllShuls", new { id = shul.IDCity.CityID });
		}

		public ActionResult EditShul(int id)
		{
			Shul shul = db.Shuls.Find(id);
			return View(shul);
		}

		public ActionResult DeleteShul(int id)
		{
			Shul s = db.Shuls.Find(id);
			int CityID = s.IDCity.CityID;
			db.Shuls.Remove(s);
			db.SaveChanges();
			return RedirectToAction("AllShuls", new { id = CityID});
		}

		public ActionResult AllShuls(int id)
		{
			var ShulList = db.Shuls.Where(s => s.IDCity.CityID == id).ToList();
			if (ShulList.Count() == 0)
			{
				Shul s = new Shul()
				{
					IDCity = db.Cities.Find(id)
				};
				ShulList.Add(s);
			}
			return View(ShulList);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AddZman(ShulViewModel model)
		{
			Shul shul = db.Shuls.Find(model.ZVM.ShulID);
			Zman zman = new Zman();
			zman.Days = model.ZVM.Days;
			if (model.ZVM.Time != null)
				zman.Time = model.ZVM.Time;
			else
				zman.OtherTime = model.ZVM.OtherTime;
			zman.Prayer = model.ZVM.Prayer;

			shul.Zmanim.Add(zman);
			db.SaveChanges();
			return RedirectToAction("ShulView", new { model.ZVM.ShulID });
		}

		public ActionResult ShulView(int ShulID)
		{
			ShulViewModel model = new ShulViewModel();
			model.ZVM = new ZmanimViewModel()
			{
				ShulID = ShulID
			};
			model.Shul = db.Shuls.Find(ShulID);
			//model.Zmanim = model.Shul.Zmanim.ToList() ?? null;
			return View(model);
		}

		public ActionResult DeleteZman(int id)
		{
			Zman z = db.Zmanim.Find(id);
			int ShulID = z.Shul.ShulID;
			db.Zmanim.Remove(z);
			db.SaveChanges();
			return RedirectToAction("ShulView", new { ShulID = ShulID });
		}
	}
}