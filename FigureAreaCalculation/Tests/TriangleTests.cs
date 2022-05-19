using System;
using FigureAreaCalculation.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void TriangleAreaCalculationTest()
		{
			//Arrange
			int firstSide = 3;
			int secondSide = 4;
			int thirdSide = 5;
			double expected = 6;
			Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

			//Act
			double actual = triangle.AreaCalculation();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TriangleIsRectangularTest()
		{
			//Arrange
			int firstSide = 3;
			int secondSide = 4;
			int thirdSide = 5;
			bool expected = true;
			Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

			//Act
			bool actual = triangle.IsRectangular;

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TriangleNegativeSideTest()
		{
			//Arrange
			int firstSide = -1;
			int secondSide = 3;
			int thirdSide = 2;
			Triangle triangle;

			//Act and assert
			Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(firstSide, secondSide, thirdSide));
		}

		[TestMethod]
		public void TriangleNonexistenTest()
		{
			//Arrange
			int firstSide = 20;
			int secondSide = 4;
			int thirdSide = 8;
			Triangle triangle;

			//Act and assert
			Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(firstSide, secondSide, thirdSide));
		}
	}
}
