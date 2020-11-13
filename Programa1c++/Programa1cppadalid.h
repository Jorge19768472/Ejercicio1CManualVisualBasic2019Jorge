#pragma once
// progrma del curso de adalid formacoin y empleo "las Mercedes 19"
// ahora sobre Visual studio C++
#include <stdio.h> // archivos de cabecera
#include <stdlib.h>// archivo de cabecera
const float PI = 3.1415936258; // Constante de tipo fload
const double PI_DOB= 3.1415936258;// vondtante de dipo double
int main()// comienzo del programa principal
{

int numero, edad;// variables de tipo entero
char unaLetra; // varible te tipo caracter
printf("¡hola mundo!\n");// muestra por pantalla

numero = 10;// asignacion de valor
printf("El valor de numero es %d ok?\n",numero);// muesta informacion con el valor
numero = 11;// asignacion de otro valor
printf("El valor de numero es %d ok?\n", numero);// muesta informacion con el valor 

printf("Otro valor %d\n", 20);// Muesta por pantalla
printf("%d x %d = %d \n", 3, 10, 3 * 10); // muestra la variables en la osicion de %d
printf("La letra %c\n",'y');// muestra por pantalla la letra 'y' en la posicion %c
printf("Pulse cual quier tecla para finalizar...\n");// Muetraque espera respuesta or teclado
unaLetra = getchar();// recoge en unaLetra lo pulsado por el usuario
printf("Has pulsado %c\n", unaLetra);// muesta por patalla la tecla pulsada
printf("El codigo ASCII de %c es %d\n",
	unaLetra, unaLetra);// instruccion en dos lineas



printf("PI = %F\n", PI);//muestra la constante pi
printf("PI_DOB= %F\n ", PI_DOB);// muestra la contante Pi_dob
return 0;// fin del progrmma

}






class Programa1cppadalid
{
};

