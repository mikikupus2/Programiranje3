#include "funkcije.h"
void main()
{
	int **a;
	int n, i, br1 = 0, br2 = 0;
	printf("Broj ekipa:");
	scanf_s("%d", &n);

	a = malloc(n * sizeof(int *));
	Unesi(a, n);
	for (i = 0; i < n; i++)
	{
		if (Prebroj(a, i, n, 3) > Prebroj(a, i, n, 0))
			br1++;
		if (Prebroj(a, i, n, 0) == 0)
			br2++;
	}
	Prikazi(a, n);
	printf("Br. ekipa sa vise pobeda : %d", br1);
	printf("Br. ekipa sa bez poraza : %d", br2);
	system("PAUSE");
}