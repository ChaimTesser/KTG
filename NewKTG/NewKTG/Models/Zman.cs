using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTG.Models
{
	public class Zman
	{
		public int ID { get; set; }
		public virtual Shul Shul { get; set; }
		//[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
		public string Time { get; set; }
		[DisplayName("Custom Time")]
		public string OtherTime { get; set; }
		public string Days { get; set; }
		public string Prayer { get; set; }

	}
}