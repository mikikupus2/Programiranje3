#include <stdio.h>
void Citaj_matricu(int** a, int m, int n, FILE *ulmat)
{
	int i, j;
	for (i = 0; i < m; i++)
		for (j = 0; j < n; j++)
			fscanf_s(ulmat, "%d", &a[i][j]); //*(a+i)+j
	return;
}