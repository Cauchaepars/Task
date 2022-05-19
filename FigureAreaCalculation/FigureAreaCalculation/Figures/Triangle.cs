using System;

namespace FigureAreaCalculation.Figures
{
	public class Triangle : Figure
	{
		int firstSide;
		int secondSide;
		int thirdSide;
		bool isRectangular;

		public bool IsRectangular { get { return isRectangular; } }

		public Triangle(int firstSide, int secondSide, int thirdSide)
		{
			if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
				throw new ArgumentException("Все стороны должны быть больше 0.");

			if (firstSide + secondSide <= thirdSide
				|| firstSide + thirdSide <= secondSide
				|| secondSide + thirdSide <= firstSide)
				throw new ArgumentException("Такого треугольника не сушествует.");

			this.firstSide = firstSide;
			this.secondSide = secondSide;
			this.thirdSide = thirdSide;

			if (firstSide > secondSide && firstSide > thirdSide)
			{
				PythagoreanTheorem(firstSide, secondSide, thirdSide);
			}
			else
			{
				if (secondSide > thirdSide && secondSide > firstSide)
				{
					PythagoreanTheorem(secondSide, firstSide, thirdSide);
				}
				else
				{
					PythagoreanTheorem(thirdSide, firstSide, secondSide);
				}
			}
		}

		public override double AreaCalculation()
		{
			float halfPerimetr = (float)(firstSide + secondSide + thirdSide) / 2;

			return Math.Sqrt((double)halfPerimetr * (halfPerimetr - firstSide) * (halfPerimetr - secondSide) * (halfPerimetr - thirdSide));
		}

		private void PythagoreanTheorem(int hypotenuse, int firstLeg, int secondLeg)
		{
			if (hypotenuse * hypotenuse == firstLeg * firstLeg + secondLeg * secondLeg)
				isRectangular = true;
		}
	}
}
