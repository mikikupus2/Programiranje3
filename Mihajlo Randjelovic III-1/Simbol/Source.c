#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* Znak(char* s, char zn)
{
	while (*s != '\0')
	{
		if (*s == zn)
		{
			return s;
			//break;
		}
		s = s + 1; 
	}
	return NULL;
}

int Brznakova(char* s, char zn)
{
	int br = 0, max = 0;
	while (*s != '\0') //>>ovo nije pisalo //while(*s) dok je vrednost s razlicito od nule posto je ASCII kod \0 ustvari 0
	{
		if (*s == zn)
		{
			br++;
			if (br > max)
				max = br;
		}
		br = 0;
		s++;
	}
	return max;
	//brp = Brznakova(s, '');//u mejnu
}
int Brsubstr(char* s, char* s1)
{
	int br = 0;
	while (strstr(s, s1) != NULL)
	{
		br++;
		s = strstr(s, s1) + strlen(s1);
	}
	return br;
}

char* Brisi(char* s, char* s1)
{
	char* p;
	while ((p = strstr(s, s1)) != NULL)
		strcpy(p, p + strlen(s1));
	return s;
}