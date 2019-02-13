using System;
using Calculator_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorRepositoryPattern_Test
{
	[TestClass]
	public class UnitTest1
	{
		CalculatorRepository calculatorRepo = new CalculatorRepository();

		[TestMethod] //NameOfProject_NameOfMethod_ExpectedResult
		public void CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectInt()
		{
			Assert.AreEqual(4, calculatorRepo.AddTwoNumbers(2, 2));
		}
		[TestMethod]
		public void CalculatorRepository_SubtractTwoNumbers_ShouldReturnCorrectInt()
		{
			Assert.AreEqual(3, calculatorRepo.SubtractTwoNumbers(6, 3));
		}
		[TestMethod]
		public void CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectInt()
		{
			Assert.AreEqual(40, calculatorRepo.MultiplyTwoNumbers(5, 8));
		}
		[TestMethod]
		public void CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectInt()
		{
			Assert.AreEqual(9, calculatorRepo.DivideTwoNumbers(81, 9));
		}
		[TestMethod]
		public void CalculatorRepository_FindRemainder_ShouldReturnCorrectInt()
		{
			Assert.AreEqual(1, calculatorRepo.FindRemainder(16, 5));
		}

		[TestMethod] //Test ALL
		public void CalculatorRepository_TestAll()
		{
			CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectInt();
			CalculatorRepository_SubtractTwoNumbers_ShouldReturnCorrectInt();
			CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectInt();
			CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectInt();
			CalculatorRepository_FindRemainder_ShouldReturnCorrectInt();
		}
	}
}
