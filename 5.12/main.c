#include <stdio.h>
/* Ordenaci�n por inserci�n directa. */
const int MAX = 100;
void Lectura(int *, int);
void Ordena(int *, int); /* Prototipos de funciones. */
void Imprime(int *, int);
void main(void)
{
int TAM, VEC[MAX];
do
{
printf("Ingrese el tama�o del arreglo: ");
scanf("%d", &TAM);
}
while (TAM>MAX || TAM<1); /* Se verifica que el tama�o del arreglo sea correcto. */
Lectura(VEC, TAM);
Ordena:(VEC, TAM);
Imprime(VEC, TAM);
}
void Lectura(int A[], int T)
/* La funci�n Lectura se utiliza para leer un arreglo unidimensional de T elementos de tipo entero. */
{
int I;
for (I=0; I<T; I++)
{
printf("Ingrese el elemento %d: ", I + 1);
scanf("%d", &A[I]);
}
}
void Imprime(int A[], int T)
/* Esta funci�n se utiliza para escribir un arreglo unidimensionalordenado de T elementos de tipo entero. */
{
int I;
for (I=0; I<T; I++)
printf("\nA[%d]: %d", I, A[I]);
}
