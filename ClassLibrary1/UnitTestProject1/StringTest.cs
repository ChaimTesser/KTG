using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class StringTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var tes = new ClassLibrary1.String();
			Assert.AreEqual(tes.glist.Length, 4);
		}
	}
}
