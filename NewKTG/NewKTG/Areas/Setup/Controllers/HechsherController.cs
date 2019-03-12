using KTG.Areas.Setup.Models;
using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Controllers
{
    public class HechsherController : Controller
    {
		Db db = new Db();
        // GET: Hechsher
        public ActionResult Index()
        {
			List<Hechsher> list = new List<Hechsher>();
			var l = db.Hechshers.OrderBy(h => h.Name).ToList();
			if (l.Count > 0)
				list = l;
			return View(list);
        }

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Hechsher h)
		{
			db.Hechshers.Add(h);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Edit(int id)
		{
			return View(db.Hechshers.Find(id));
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Activity a)
		{
			db.Entry(a).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			return View(db.Hechshers.Find(id));
		}

		public ActionResult Delete(int id)
		{
			Hechsher h = db.Hechshers.Find(id);
			db.Hechshers.Remove(h);
			db.SaveChanges();
			return RedirectToAction("index");
		}
	}
}