using KTG.Areas.Setup.Models;
using KTG.Helpers;
using KTG.Models;
using KTG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTG.Areas.Setup.Controllers			
{
	public class HomeController : Controller
	{
		Db db = new Db();
		Helper Helper = new Helper();
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult ViewState(string state)
		{
			StateViewModel model = new StateViewModel();
			model.StateName = Helper.stateAbbreviationExpand(state);
			model.Cities = db.Cities.Where(c => c.State == state).ToList();
			return View(model);
		}
	}
}