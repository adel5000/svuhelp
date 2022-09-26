using System;

public class Program
{
	public static void Main()
	{
		//Block0
		int a, b = 12;
		//Block1
		{
			int x, y = 8;
		}

		// Block2
		{
			int z = 12;
			a = b + z;
			x = z; //error
			a = x + 1; //error
		}

		//Block3
		{
			int u = 1;
			a = b - u;
			y = u - b; //error
		}
	}
}
