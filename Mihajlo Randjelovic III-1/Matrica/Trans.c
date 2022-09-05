void Transponuj(int** a, int** b, int m, int n)
{
	int i, j;
	for (i = 0; i < m; i++)
		for (j = 0; j < n; j++)
			b[j][i] = a[i][j];
	return;
}