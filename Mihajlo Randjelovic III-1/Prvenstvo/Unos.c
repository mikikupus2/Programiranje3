#include "funkcije.h"					
void Unesi(int *a, int n)
{
	int i, j;
	for (i = 0; i < n; i++)
	{
		a[i] = malloc(n * sizeof(int));
		for (j = 0; j < n; j++)
		{
			printf("Unesi rezultat a[%d][%d]", i, j);
			scanf_s("%d", &a[i + j]);
		}
	}
	return;
}