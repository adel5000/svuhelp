using System;

public class Program
{
	public static void Main()
	{
		int a = 0, b = 0, c = 0;
		a = a == 0 ? b + (a = -5) : a + 1;
		b = a >= 0 ? b - 1 : b = 10;
		c = (a + b) > 0 ? a++ : a--;
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
		Console.WriteLine("c = " + c);
	}
}
