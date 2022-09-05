#include "funkcije.h"
int Prebroj(int **a, int i, int n, int vrednost)
{
	int j, broj;
	broj = 0;
	for (j = 0; j < n; j++)
		if (a[i][j] == vrednost && i != j)
			broj++;
	return broj;
}