long stepen(int x, int n)
{
	int i;
	long p = 1;
	for (i = 0; i < n; i++)
		p = p * x;
	return p;
}