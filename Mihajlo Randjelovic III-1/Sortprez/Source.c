#include <stdio.h>
#include <stdlib.h>
#include <string.h>
void main()
{
	FILE* ul, * izl;
	char** a, pom[31], * pp;
	int i, j, n;
	errno_t gr;
	gr = fopen_s(&ul, "prezimena.txt", "r");
	if (gr == 0)
	{
		fscanf_s(ul, "%d\n", &n);
		a = malloc(n * sizeof(char*));
		for (i = 0; i < n; i++)
			a[i] = malloc(31 * sizeof(char));
		for (i = 0; i < n; i++)
			fgets(a[i], 31, ul);
		/*
		for (i = 0; i < n - 1; i++)
			for (j = i + 1; j < n; j++)
				if (strcmp(a[j], a[i]) < 0)
				{
					strcpy_s(pom, 31, a[j]);
					strcpy_s(a[j], 31, a[i]);
					strcpy_s(a[i], 31, pom);
				}
		*/
		for (i = 0; i < n - 1; i++)
			for (j = i + 1; j < n; j++)
				if (strcmp(a[j], a[i]) < 0)
				{
					pp = a[i];
					a[i] = a[j];
					a[j] = pp;
				}
		gr = fopen_s(&izl, "Sortirano.txt", "w");
		for (i = 0; i < n; i++)
			fputs(a[i], izl);
		fclose(ul);
		fclose(izl);
	}
	else printf("Fajl nije otvoren !!!");
	system("PAUSE");
}