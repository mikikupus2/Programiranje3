#include <stdio.h>

void main()
{

	int n;
	double* p;
	printf("n=");
	scanf_s("%d", &n);
	p = malloc(n * sizeof(double));
	Unesi(p, n);
	Prikazi(p, n);
	Sortiraj(p, n);
	Prikazi(p, n);
	free(p);
}