using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamentals_InATestProject
{
	[TestClass]
	public class Tax
	{
		public double CalculateGross(double net)
		{
			return net * 1.07;
		}

		[TestMethod]
		public void MyTestMethod()
		{
			double net = 19.99;
			double gross = CalculateGross(net);
			Assert.AreEqual(gross, 21.3893);
		}
	}
}