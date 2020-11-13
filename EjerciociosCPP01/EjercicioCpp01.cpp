// EjerciociosCPP01.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include "menu_principal.h"
#include "alumnos.h"
#include "alumno_st.h"
#include <stdlib.h>
#include <stdio.h>
using namespace std;

int main()
{
    int numero = 200, mi500 = 500;
    int* ptr_num = &numero;
    cout << &numero << endl;
    cout << ptr_num << endl;
   *ptr_num = 300; 
   cout << *ptr_num <<endl:
    
   ptr_num = &mi500;
   *ptr_num = 555;

   cout << *ptr_num << endl;
   cout << mi500 << endl;

   getchar();

   int opcion = 1;

   while (opcion != 0) {
       opcion = munuPrinciipal();
       switch (opcion) {
       case 1:
           menu_alumnos_st();
           break;

       case 2:
           cout << "curdso" << endl;
           break;

       case 0:
           cout << "Adios" << endl;
           break;

       default:
           cout << "Error opcion no Valida" << endl;
           break;



       }// FIN SDE SWITH
   } ///FIN WHILE
   return 0;
   
   }/// FIN fUNCION






// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
