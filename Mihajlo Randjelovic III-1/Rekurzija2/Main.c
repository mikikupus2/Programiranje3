#include <stdio.h>
void main()
{
	int n;
	int Fibonaci(int n);
	printf("n=");
	scanf_s("%d", &n);
	printf("\n%d-ti element Fib. niza je=%d", n, Fibonaci(n));

}