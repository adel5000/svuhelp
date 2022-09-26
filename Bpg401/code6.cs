using System;

public class Program
{
	public static void Main()
	{
		int a = 100, b = 0, c;
		if (b == 0)
		{
			c = 1;
			System.Console.WriteLine("First Condition: c = " + c);
		}
		else
		{
			c = a / b;
			System.Console.WriteLine("First Condition: c = " + c);
		}

		if ((c = a * b) != 0)
			c += b;
		else
			c = a;
		System.Console.WriteLine("Second Condition: c = " + c);
	}
}
