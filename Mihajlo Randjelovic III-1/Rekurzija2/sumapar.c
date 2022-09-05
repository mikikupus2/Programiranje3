int Suma_par(int n)
{
	if (n == 0)
		return n;
	return n + Suma_par(n - 2);
}