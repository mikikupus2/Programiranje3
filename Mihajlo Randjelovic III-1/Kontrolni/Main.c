/*napisati funkciju koja u nizu celih brojeva koji se unosi sa tastature svaki element cija je vrednost 
nula zamenjuje sa rednim brojem pojavljivanje nule u nizu.
pozvati funkciju sa pokazivacima*/
#include <stdio.h>
#include <stdlib.h>
/*void unos(int a[], int n)
{
	int i;
	for (i = 0; i < n; i++)
	{
		printf("Element sa indeksom %d=", i);
		scanf_s("%d", &a[i]);
	}
}
void prikaz(int a[], int n)
{
	int i;
	printf("Niz:");
	for (i = 0; i < n; i++)
	{
		printf("%d ", a[i]);
	}
}
void funkcija(int a[], int n)
{
	int i, br = 1;
	for (i = 0; i < n; i++)
	{
		if (a[i] == 0)
		{
			a[i] = br;
			br++;
		}
	}
}*/
void unos(int* a, int n)
{
	int* p;
	for (p = a; p < a + n; p++)
	{
		printf("Element sa indeksom %d=", p - a);
		scanf_s("%d", p);
	}
}
void prikaz(int* a, int n)
{
	int* p;
	printf("Niz :");
	for (p = a; p < a + n; p++)
	{
		printf("%d ", *p);
	}
}
void funkcija(int* a, int n)
{
	int* p, br = 1;
	for (p = a; p < a + n; p++)
	{
		if (*p == 0)
		{
			*p = br;
			br++;
		}
	}
}
void main()
{
	int* a, n;
	printf("n=");
	scanf_s("%d", &n);
	a = malloc(n * sizeof(int));
	unos(a, n);
	prikaz(a, n);
	funkcija(a, n);
	prikaz(a, n);
}
