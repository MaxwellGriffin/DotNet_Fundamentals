using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Example;

namespace Class_Example_Tests
{
	[TestClass]
	public class Cookie_Tests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Cookie cookie = new Cookie();
			cookie.Name = "Sugar Cookie";
			cookie.IsGlutenFree = false;
			cookie.Ingredient = "Flour and sugar";
			cookie.BatchSize = 45;

			Cookie cookieTwo = new Cookie();
			cookie.Name = "Peanut Butter Cookie";
			cookie.IsGlutenFree = false;
			cookie.Ingredient = "Peanut butter";
			cookie.BatchSize = 36;

			Cookie cookieThree = new Cookie();
			cookie.Name = "Nasty Cookie";
			cookie.IsGlutenFree = true;
			cookie.Ingredient = "Soy, human flesh";
			cookie.BatchSize = 666;

			Cookie cookieFour = new Cookie();
			cookie.Name = "Chocolate Chip";
			cookie.IsGlutenFree = false;
			cookie.Ingredient = "Chocolate Chips";
			cookie.BatchSize = 48;

			WriteCookieList();
		}

		private void WriteCookieList()
		{

		}
	}
}
