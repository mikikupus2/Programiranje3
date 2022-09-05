#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h> 
int funkcija(FILE *ul)
{
	int i=0;
	char red[101];
	while (fgets(red, 100, ul) != NULL)
	{
		if (strlen(red) > i)
		{
			i = strlen(red);
		}
	}
	return i;
}

void main()
{
	char tekst[101];
	int max = 0;
	FILE* ul, * izl;
	errno_t gr;
	gr = fopen_s(&ul, "tekst.txt", "r");
	if (gr == 0)
	{
		fopen_s(&izl, "tekst2.txt", "w");
		max = funkcija(ul);
		fclose(ul);
		fopen_s(&ul, "tekst.txt", "r");
		while (fgets(tekst, 100, ul))
		{
			if (strlen(tekst) == max)
			{
				fputs(tekst, izl);
			}
		}
		fclose(izl);
	}
	else
		printf("Datoteka tekst.txt nije otvorena!!!");
	system("PAUSE");
}