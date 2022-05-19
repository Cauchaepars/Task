using System;

namespace FigureAreaCalculation.Figures
{
	public class Circle : Figure
	{
		private double radius;

		public Circle(double radius)
		{
			if (radius <= 0)
				throw new ArgumentException("Радиус должен быть больше 0.");

			this.radius = radius;
		}

		public override double AreaCalculation()
		{
			return Math.PI * radius * radius;
		}
	}
}
