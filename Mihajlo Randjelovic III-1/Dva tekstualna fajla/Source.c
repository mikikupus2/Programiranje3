#include <stdio.h>
#include <stdlib.h>
void main()
{
	FILE* f1, * f2, * f3;
	errno_t gr, gr1;
	char red[101];
	gr = fopen_s(&f1, "tekst1.txt", "r");
	gr1 = fopen_s(&f2, "tekst2.txt", "r");
	if (gr == 0 && gr1 == 0)
	{
		gr = fopen_s(&f3, "tekst3.txt", "w");
		while ((fgets(red, 100, f1)) != EOF)
			fputs(red, f3);
		while ((fgets(red, 100, f2)) != EOF)
			fputs(red, f3);
	}
	else
		printf("Otvaranje fajlova nije uspelo");
	system("PAUSE");
}