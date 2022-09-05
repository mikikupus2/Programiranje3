#include "funkcije.h"
void Prikazi(int **a, int n)
{
	int i, j;
	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
			printf("%d", a[i][j]);
		printf("\n");
	}
}