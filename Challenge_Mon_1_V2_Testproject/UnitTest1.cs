using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge_Mon_1_V2; //needed

namespace Challenge_Mon_1_V2_Testproject
{
	[TestClass]
	public class TuesdayTests
	{
		Content _contentTest = new Content();
		ReadWrite rw = new ReadWrite();

		[TestMethod]
		public void TestMethod1()
		{
			//Arrange
			var contentList = new List<Content>();
			contentList.Add(new Content());
			//Act

			//Assert

		}

		[DataTestMethod]
		[DataRow(1)]
	}
}
