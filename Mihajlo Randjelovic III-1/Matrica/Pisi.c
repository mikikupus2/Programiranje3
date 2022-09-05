#include <stdio.h>
void Pisi_matricu(FILE* mat, int** a, int m, int n)
{
	int i, j;
	for (i = 0; i < m; i++)
	{
		for (j = 0; j < n; j++)
			fprintf(mat, "%5d", a[i][j]);
		fprintf(mat, "\n");
	}
	return;
}