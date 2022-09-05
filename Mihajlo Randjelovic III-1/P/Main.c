#include <stdio.h>
#include "Pokm.h"
void main()
{
	int m, n;
	float a[10][10], ars;
	printf("Broj vrsta matrice=");
	scanf_s("%d", &m);
	printf("Broj kolona matrice=");
	scanf_s("%d", &n);
	Unosm(a, m, n);
	ars = Prosekm(a, m, n);
	Prikazm(a, m, n);
	printf("\n\n%8.2f", ars);
	system("PAUSE");
}