#include <stdio.h>
#include <stdlib.h>



int main()
{
    float entrada = 0.0;
    float salida = 0.0;
    int fin = 1;



    while(fin != 0)
    {
        do
        {
            printf("Programa Calculo itbis\n");
            printf("Ingrese el Costo = ");
            scanf("%f",&entrada);



            if(entrada < 0.0)
            {
                printf("\nEl precio es negativo, intente de nuevo");
            }



            if(entrada == 0)
            {
                fin = 0;
                printf("\nFin de Programa!\n");
            }



        }while(entrada < 0);



        if(entrada > 0)
        {
            //calculo
            //salida = entrada + (entrada * 0.18);
            salida = entrada + ((entrada * 18) / 100);



            printf("\n\nEl itebis es: %f", entrada*0.18);
            printf("\n\nEl Precio es: %f", salida);
            printf("\n\n");



        }





    }





    return 0;
}

