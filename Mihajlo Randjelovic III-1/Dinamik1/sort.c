void Sortiraj(double *p, int n)
{
	int i, j;
	double pom;
	for(i=0;i<n-1;i++)
		for(j=i+1;j<n;j++)
			if (p[j] < *(p + i))
			{
				pom = p[i];
				p[i] = p[j];
				p[j] = pom;
			}
	return;
}