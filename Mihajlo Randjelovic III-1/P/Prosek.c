float Prosekm(float *x, int m, int n)
{
	float s = 0;
	float* p;
	for (p = x; p < x + m * n; p++)
		s = s + *p;
	return s / (m * n);
}