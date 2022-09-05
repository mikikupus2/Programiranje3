/*U tekstualnom fajlu zapisana je kvadratna matrica tako sto je u prvom redu jedan ceo broj koji predstavlja red ili
dimenziju matrice,a zatim u svakom sledecem redu po jedna vrsta matrice.
Procitati matricu iz tekstualnog fajla i smestiti je u dinamicku zonu memorije, prikazati matricu na ekranu, 
napisati funkciju koja odredjuje indekse najveceg elementa u matrici. 
Pozvati funckiju i prikazati indeks.
*/
#include <stdio.h>
#include <stdlib.h>
void index(int** a, int n, int* indeksi)
{
	int i, j;
	int max = a[0][0];
	for (i = 0; i < n; i++)
		for (j = 0; j < n; j++)
		{
			if (a[i][j] > max)
			{
				max = a[i][j];
				indeksi[0] = i;
				indeksi[1] = j;
			}
		}
}
void main()
{
	FILE* f1;
	errno_t gr;
	int i, j, n, ** a, *indeksi;
	gr = fopen_s(&f1, "tekst.txt", "r");
	if (gr == 0)
	{
		fscanf_s(f1, "%d", &n);
		a = malloc(n * sizeof(int));
		for (i = 0; i < n; i++)
		{
			a[i] = malloc(n * sizeof(int));
			for (j = 0; j < n; j++)
			{
				fscanf_s(f1, "%d", &a[i][j]);
			}
		}
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				printf("%d ", a[i][j]);
			}
			printf("\n");
		}
		indeksi = malloc(2 * sizeof(int));
		index(a, n, indeksi);
		printf("Indeksi najveceg elementa u matrici: %d, %d\n", indeksi[0], indeksi[1]);
		system("PAUSE");
	}
	else
		printf("Otvaranje fajla tekst.txt nije uspelo");

}