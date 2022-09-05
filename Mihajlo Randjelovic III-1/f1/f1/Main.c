#include <stdio.h>
#include <math.h>


void main()
{
	float a, b, c;
	float hipotenuza(float, float);
	printf("a=");
	scanf_s("%f", &a);
	printf("b=");
	scanf_s("%f", &b);
	c = hipotenuza(a, b);
	printf("%6.2f %6.2f %8.2f", a, b, c);
	system("PAUSE");
}

float hipotenuza(float x, float y)
{
	float z;
	z = (float)sqrt(x * x + y * y);
	return z;
}