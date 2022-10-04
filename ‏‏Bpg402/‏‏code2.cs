using System;

public class Program
{
	public static void Main()
	{
		int i = 0;
		int y = 8;
		Console.WriteLine(i<5 == 0>y);
		// (0 < 5) == (0 > 8)
		// (T) == (F) ==> (False)
		Console.WriteLine(i<5 != 0>y);
		// (0 < 5) != (0 > 8)
		// (T) != (F) ==> (True)	
	}
}