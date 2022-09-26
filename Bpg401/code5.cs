//Block0
int a, b = 12;
//Block1
{
	int x, y = 8;
	{
		int k = 0;
		x = a * y;
		k = k + z;
	}
}

// Block2
{
	int z = 12;
	a = z + b;
	{
		int u = 0;
		x = a * y;
		u++;
	}
}

//Block3
{
	int u = 1;
	a = u - b;
	z = u - b;
}
