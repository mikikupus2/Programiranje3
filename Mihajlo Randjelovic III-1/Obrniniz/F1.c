void Obrni(int *a, int n)
{/*
	int i = 0, j = n - 1;
	int pom;
	for (i = 0, j = n - 1; i < j; i++, j--)
	{
		pom = a[i];
		a[i] = a[j];
		a[j] = pom;
	}
	return;
	*/

	int* p1, * p2;
	int pom;
	for (p1 = a, p2 = a + n - 1; p1 < p2; p1++, p2--)
	{
		pom = *p1;
		*p1 = *p2;
		*p2 = pom;
	}
	return;
}