using System;

namespace Perfect
{
	class ApplicationPerfect
	{
		static void Main(string[] args)
		{
			int compt = 0, n, k, sumdiv, nbr;
			Console.Write("Number of Perfect numbers you wish find : ");
			n = Int32.Parse(Console.ReadLine());
			nbr = 2;
			while (compt != n)
			{
				sumdiv = 1;
				k = 2;
				while (k <= nbr / 2)
				{
					if (nbr % k == 0)
						sumdiv += k;
					k++;
				}

				if (sumdiv == nbr)
				{
					Console.WriteLine(nbr + " is a Perfect number");
					compt++;
				}

				nbr++;
			}
		}
	}
}
