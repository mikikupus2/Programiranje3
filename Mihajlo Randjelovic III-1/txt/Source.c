#include <stdio.h>
#include <stdlib.h>
#define MAX 80
void main()
{
	FILE* ful, * fiz;
	char red[81];
	errno_t greska;
	//ful = fopen("tekst1.txt", "r");
	if ((greska = fopen_s(&ful, "D:\\Mihajlo Randjelovic II-1\\txt\\tekst1.txt", "r")) == 0)
	{
		if ((greska = fopen_s(&fiz, "D:\\Mihajlo Randjelovic II-1\\txt\\tekst2.txt", "w")) == 0)
		{
			while ((fgets(red, MAX, ful)) != NULL)
				fputs(red, fiz);
		}
		else
			printf("Fajl tekst2.txt nije otvoren !!!");
		fclose(fiz);
	}
	else
		printf("Datoteka tekst1.txt nije otvorena !!!");
	fclose(ful);
	system("PAUSE");
}