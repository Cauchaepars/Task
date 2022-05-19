using System;
using FigureAreaCalculation.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class CircleTests
	{
		[TestMethod]
		public void CircleAreaCalculationTest()
		{
			//Arrange
			double radius = 6;
			double expected = radius * radius * Math.PI;
			Circle circle = new Circle(radius);

			//Act
			double actual = circle.AreaCalculation();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CircleNegativeRadiusTest()
		{
			//Arrange
			double radius = -1;
			Circle circle;

			//Act and assert
			Assert.ThrowsException<ArgumentException>(() => circle = new Circle(radius));
		}
	}
}
