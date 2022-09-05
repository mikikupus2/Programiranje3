#include <stdio.h>
int Broj_poz(int a[], int n)
{
	int i, brpoz = 0;
	for (i = 0; i < n; i++)
		if (a[i] > 0)
			brpoz++;
	return brpoz;
}