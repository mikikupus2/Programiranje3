int Fibonaci(int n)
{
	/*if (n == 0 || n == 1)
		return n;
	return Fibonaci(n - 1) + Fibonaci(n - 2);
}
*/

	int f0, f1, f2, i;
	f0 = 0;
	f1 = 1;
	printf("%6d%6d", f0, f1);
	i = 2;
	while (i < n)
	{
		f2 = f0 + f1;
		printf("%6d", f2);

		f0 = f1;
		f1 = f2;
		i = i + 1;
	}
	return f2;
}