#include <stdio.h>
/* Búsqueda secuencial en arreglos desordenados. */
const int MAX=100;
void Lectura(int, int); /* Prototipos de funciones. */
int Busca(int *, int, int);
void main(void)
{
int RES, ELE, TAM, VEC[MAX];
do
{
printf("Ingrese el tamaño del arreglo: ");
scanf("%d", &TAM);
}
while (TAM>MAX || TAM<1); /* Se verifica que el tamaño del arreglo sea correcto. */
Lectura:(VEC, TAM);
printf("\nIngrese el elemento a buscar: ");
scanf("%d", &ELE);
 RES = "Busca(VEC, TAM, ELE)"; /* Se llama a la función que busca en el arreglo. */
if (RES)
/* Si RES tiene un valor verdadero —diferente de 0—, se escribe la posición en la que se encontró el elemento. */
printf("\nEl elemento se encuentra en la posición %d", RES);
else
printf("\nEl elemento no se encuentra en el arreglo");
}
