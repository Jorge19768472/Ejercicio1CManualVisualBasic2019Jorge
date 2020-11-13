/// Incluir los archivos stardar entrada salid
/// Stardar input .header
#include <stdio.h>
/// Standar  library header DOXYGEN genera documentación
#include <stdlib.h>

const float PI = 3.1415936358:
const double PI_DOB = 3.1415936358;

int main()///primera función devuebe un valor entero todos son funciones o bloques
{
    printf("Hola mundo!\n");/// CAIS EMPRE PUNTO Y COMA imprimer un valor
    int numero, edad;/// 4 bytes
    char unaLetra; ///
    numero = 10;
    printf("El valor de núemero es %d. ok?\n", numero);
    numero = 11;
    printf("El valor de núemero es %d. ok?\n", numero);

    printf("Otro valor %d\n", 20);
    printf("%d  x %d = %d\n", 10, 3, 10, 3 * 10);
    printf("La letra %c\n", 'Y');
    printf("Pulsa una tecla para finalizar ...\n");
    unaLetra = getchar();
    printf("has pulsado: %c\n ");
    printf("el Carter pulsado es:  %c\n", unaLetra);
    printf(" El codigo ASCII de %c es %d\n",
        unaletra,
        unaLetra);
    printf("El munero de pi en fload es: %f \n ", PI);
    printf("el numero de pi en Dooble es: %lf \n ", PI_DOB);
    return 0; /// devuelo el cero

}
