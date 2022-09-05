#include <stdio.h>
void Unosm(float *x, int m, int n)
{
	float *p;
	for (p = x; p < x + m * n; p++)
	{
		printf("a[%d][%d]", (p - x) / n, (p - x) % n);
		scanf_s("%f", p);
	}
	return;
}include <stdio.h>
void Unosm(float* x, int m, int n)
{
	float* p;
	for (p = x; p < x + m * n; p++)
	{
		printf("a[%d][%d]", (p - x) / n, (p - x) % n);
		scanf_s("%f", p);
	}
	return;
}
/*
include <stdio.h>
void Unosm(float *x, int m, int n)
{
	int i, j;
	for (i=0;i<m;i++)
	{
		for(j=0;j<n;j++)
		{
			printf("a[%d][%d]=");
			scanf_s("%f", x+n*i+j);

		}
	}
	return;
}
*/
