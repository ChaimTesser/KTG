using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class String
	{
		public string[] glist;
		public String()
		{
			glist = new string[4] { "b", "c", "d", "e" };
		}

		public override string ToString()
		{
			return "There are " + glist.Length;
		}
	}
}
