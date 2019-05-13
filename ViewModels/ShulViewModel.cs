using KTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KTG.ViewModels
{
	public class ShulViewModel
	{
		public Shul Shul { get; set; }
		public List<Zman> Zmanim { get; set; }
		public ZmanimViewModel ZVM { get; set; }
		public Zman Z = new Zman();
	}
}