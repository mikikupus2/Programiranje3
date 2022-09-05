#include <stdio.h>
#include <stdlib.h>
#include <math.h>
struct kompleks
{
	float real;
	float imag;
};
void main()
{
	float c;
	struct kompleks x;
	printf("realni deo:");
	scanf_s("%f", &x.real);
	printf("imaginarni deo:");
	scanf_s("%f", &x.imag);
	c = sqrt(x.real * x.real + x.imag * x.imag);
	printf("%f,%f\n", c, -c);
	system("PAUSE");
}