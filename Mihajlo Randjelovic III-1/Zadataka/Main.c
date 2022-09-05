/*napisati funkciju koja izracunava dve sume u celobrojnom nizu, 
sumu parnih i sumu neparniyh elemenata niza, i kao rezultat vraca 
vecu od njih.*za pristup elemenata niza koristiti i indekse i 
pokazivace u okviru glavnog programa unose se elementi niza, 
poziva se fja na izvrsenje, 
prikazuje niz i prikazuje rezultat*/
#include <stdio.h>
#include <stdlib.h>
int funkcija(int* a, int n)
{
	int par = 0, nepar = 0, max, i;
	for (i = 0; i < n; i++)//(p=a;p<a+n;p++)
	{
		if (*(a+i) % 2 == 0)
		{
			par += *(a + i);
		}
		else
			nepar += *(a + i);
	}
	if (par > nepar)
		max = par;
	else
		max = nepar;
	return max;
}

void main()
{
	int i, j, * a, max, n;
	printf("n=");
	scanf_s("%d", &n);
	a = malloc(n * sizeof(int));
	for (i = 0; i < n; i++)
	{
		printf("Element%d=", i);
		scanf_s("%d", a + i);
	}
	max = funkcija(a, n);
	for (i = 0; i < n; i++)
	{
		printf("%d ", *(a + i));
		
	}
	printf("Veca suma je:%d", max);
}