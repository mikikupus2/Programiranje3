#include <stdio.h>
int Suma(int n)
{
	if (n == 1)
		return 1;
	return n + Suma(n - 1);
}
void main()
{
	int n, s;
	printf("n=");
	scanf_s("%d", &n);
	s = Suma(n);
	printf("s=%d\n", s);
	system("PAUSE");
}