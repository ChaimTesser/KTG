using KTG.Models;
using KTG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Controllers
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
				CityID = db.Cities.Find(model.CityCode),
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
			Shul s = db.Shuls.Find(shul.ShulID);
			s.Address = shul.Address;
			s.City = shul.City;
			s.Country = shul.Country;
			s.Email = shul.Email;
			s.Name = shul.Name;
			s.Nusach = shul.Nusach;
			s.Phone = shul.Phone;
			s.State = shul.State;
			s.Zip = shul.Zip;
			s.Website = shul.Website;
			s.Rabbi = shul.Rabbi;
			db.SaveChanges();
			return RedirectToAction("AllShuls", new { id = 1 });
		}

		public ActionResult EditShul(int id)
		{
			Shul shul = db.Shuls.Find(id);
			return View(shul);
		}

		public ActionResult DeleteShul(int id)
		{
			Shul s = db.Shuls.Find(id);
			int CityID = s.CityID.CityID;
			db.Shuls.Remove(s);
			db.SaveChanges();
			return RedirectToAction("AllShuls", new { id = CityID});
		}

		public ActionResult AllShuls(int id)
		{
			var ShulList = db.Shuls.Where(s => s.CityID.CityID == id).ToList();
			if (ShulList.Count() == 0)
			{
				Shul s = new Shul()
				{
					CityID = db.Cities.Find(id)
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