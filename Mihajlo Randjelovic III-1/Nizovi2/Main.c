#include <stdio.h>
#include <stdlib.h>
#include "fniz.h"
void main()
{
	int a[100], n, izbor, maxel, brpoz;
	do
	{
		system("CLS");
		printf("\n\n          FUNKCIJE ZA RAD SA NIZOVIMA\n\n");
		printf("1. Unos elemenata niza\n\n");
		printf("2. Prikazivanje niza na ekranu\n\n");
		printf("3. Odredjivanje maximalnog elementa\n\n");
		printf("4. Odredjivanje broja pozitivnih\n\n");
		printf("5. Kraj\n\n\n");
		printf("             Izbor:");
		scanf_s("%d", &izbor);

		switch (izbor)
		{
		case 1:
			n = Unesi_niz(a);
			break;
		case 2:
			Prikazi_niz(a, n);
			break;
		case 3:
			maxel = Max_niz(a, n);
			printf("Maksimalni element niza je:%d\n\n", maxel);
			break;
		case 4:
			brpoz = Broj_poz(a, n);
			printf("Broj pozitivnih elemenata je:\n\n", brpoz);
			break;
		case 5:
			break;
		}

		system("PAUSE");
	} while (izbor != 5);
}