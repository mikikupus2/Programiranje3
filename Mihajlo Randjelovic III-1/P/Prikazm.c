#include <stdio.h>
void Prikazm(float *x, int m, int n)
{
	float* p;
	for (p = x; p < x + m * n; p++)
	{
		if ((p - x) % n == 0)
			printf("\n");
		printf("%6.2f", *p);
	}
}