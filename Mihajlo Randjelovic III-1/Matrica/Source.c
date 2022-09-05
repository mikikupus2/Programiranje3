#include <stdlib.h>
#include "Zag.h"
void main()
{
	FILE* ulmat, * izmat;
	int** a, **b, m, n, i, j;
	errno_t greska;
	if ((greska = fopen_s(&ulmat, "matricaA.txt", "r")) == 0)
	{
		fscanf_s(ulmat, "%d", &m);
		fscanf_s(ulmat, "%d", &n);
		a = malloc(m * sizeof(int*));
		for (i = 0; i < m; i++)
			*(a + i) = malloc(n * sizeof(int));
		
		Citaj_matricu(a, m, n, ulmat);
		greska = fopen_s(&izmat, "matricaB.txt", "w");
		b = malloc(n * sizeof(int*));
		for (i = 0; i < n; i++)
			*(b + i) = malloc(m * sizeof(int));
		Transponuj(a, b, m, n);
		Pisi_matricu(izmat, b, n, m);
		fclose(ulmat);
		fclose(izmat);
	}
	else
		printf("Ulazna datoteka nije otvorena !!!\n");
	system("PAUSE");
}