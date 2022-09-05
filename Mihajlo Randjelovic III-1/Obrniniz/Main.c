#include <stdio.h>
void main()
{
	int Obrni(int *a, int n);
	int *niz, n, i;
	printf("n=");
	scanf_s("%d", &n);
	niz = malloc(n * sizeof(int));
	for (i = 0; i < n; i++)
	{ 
		printf("a[%d]=", i);
		scanf_s("%d", niz+i);
	}
	printf("Originalni niz:\n");
	for (i = 0; i < n; i++)
		printf("%5d", *(niz+i));
	printf("\n\n");
	Obrni(niz, n);
	printf("Obrnuti niz:\n");
	for (i = 0; i < n; i++)
		printf("%5d", *(niz+i));
	printf("\n\n");
}