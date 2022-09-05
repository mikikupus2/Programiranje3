#include <stdio.h>
#include "Step.h"
void main()
{
	int a, n;
	long s;
	printf("a=");
	scanf_s("%d", &a);
	printf("n=");
	scanf_s("%d", &n);
	s = stepen(a, n);
	printf("%d %d %ld \n", a, n, s);
	system("PAUSE");
}