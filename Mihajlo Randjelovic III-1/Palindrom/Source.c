#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int Palindrom(char *s, int n)
{
	int i, j, r=1;
	for (i = 0, j = n - 1; i != j; i++, j--)
		if (s[i] != s[j])
		{
			r = 0;
			break;
		}
	return r;
}

void main()
{
	FILE* ul, * izl;
	errno_t gr1, gr2;
	int n;
	char red[81];
	gr1 = fopen_s(&ul, "tekst1.txt", "r");
	if (gr1 == 0)
	{
		gr2 = fopen_s(&izl, "tekst2.txt", "w");
		while (fgets(red, 80, ul) != NULL)
		{
			n = strlen(red);
			if (Palindrom(red, n-1) == 1)
				fputs("PALINDROM\n", izl);
			else
				fputs("NIJE PALINDROM\n", izl);
		}
		fclose(ul);
		fclose(izl);
	}
	else
		printf("Ulazni fajl nije otvoren !!!");
	system("PAUSE");
}