using System;

namespace Examples
{
	class Solution2degreeAll
	{ // Solution of second degree equation : a.x2 + b.x + c = 0
		public static void Main(string[] arg)
		{
			double a;
			String Sa;
			double b;
			String Sb;
			double c;
			String Sc;
			double delta, x, x1, x2;
			// Read a,b, c
			Console.Write(" Input a =");
			Sa = Console.ReadLine();
			a = Double.Parse(Sa);
			Console.Write(" Input b =");
			Sb = Console.ReadLine();
			b = Double.Parse(Sb);
			Console.Write(" Input c =");
			Sc = Console.ReadLine();
			c = Double.Parse(Sc);
			if (a == 0)
			{
				if (b == 0)
				{
					if (c == 0)
					{
						Console.WriteLine("Each Real is a solution");
					}
					else
					{ // c ≠ 0
						Console.WriteLine("Incorrect Equation");
					}
				}
				else
				{ // b ≠ 0
					x = -c / b;
					Console.WriteLine("The Solution is : " + x);
				}
			}
			else
			{ // a ≠ 0
				delta = b * b - 4 * a * c;
				if (delta < 0)
					Console.WriteLine(" No Real Solution ");
				if (delta == 0)
				{
					Console.WriteLine(" One Solution ");
					x = -b / (2 * a);
					Console.WriteLine(" x= " + x);
				}

				if (delta > 0)
				{
					Console.WriteLine(" Two Solutions ");
					x1 = (-b - Math.Sqrt(delta)) / (2 * a);
					x2 = (-b + Math.Sqrt(delta)) / (2 * a);
					Console.WriteLine(" x1= " + x1 + " x2= " + x2);
				}
			}
		}
	}
