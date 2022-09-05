#include <stdio.h>
int Max_niz(int a[], int n)
{
	int i, maks;
	maks = a[0];
	for (i = 1; i < n; i++)
		if (a[i] > maks)
			maks = a[i];
	return maks;
}