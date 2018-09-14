#include  <stdio.h>
#include <stdlib.h>
/*
Programa para encontrar el numero faltante en un conjunto sucesivo desorganizado
*/
int main() {

	printf("El conjunto es: \n");
	int i, result, N;
	int a[] = {5,2,4,1,6,7};
	N = sizeof(a)/sizeof(a[0]);
		for (i=0;i<N;i++)
	{
		printf(" %d ",a[i]);
	}
	 result = NumFalt(a, N);
	printf("\nEl numero faltante es: %d", result);
}

int NumFalt(int array[], int size)
{
	int i, N, sumArrayComp, sumArray=0;
	N = size+1;
	sumArrayComp = (N * (N+1))/2; //Sumatoria del conjunto completo
	
	for (i=0;i<N-1;i++)
	{
		sumArray += array[i]; //sumatoria del conjunto con un elemento faltante
	}
	
	return sumArrayComp - sumArray; // la diferencia es el elemento faltante
}
