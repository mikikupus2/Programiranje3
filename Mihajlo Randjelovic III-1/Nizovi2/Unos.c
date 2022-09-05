#include <stdio.h>
int Unesi_niz(int x[])
{
	int n, i;
	printf("n=");
	scanf_s("%d", &n);
	for (i = 0; i < n; i++)
	{
		printf("a[%d]", i);
		scanf_s("%d", &x[i]);
	}
	return n;
}