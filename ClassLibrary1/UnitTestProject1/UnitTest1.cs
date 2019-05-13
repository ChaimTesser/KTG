using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var test = new Class1();
			var testres = test.add(3, 5);
			Assert.AreEqual(8, testres, "Expected 14");
		}
	}
}
