// ejarciion1c++.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
// operaciones artimeticas

#include <iostream>
 
int main()
{
    // Variabloes 
   int dato1, dato2, resultado ;//

    printf("variable 1\n"); // muestra infoamcin
    std::cin>> dato1; // pide infomacion
    printf("variable 2\n");// muestra infoamcio 
   
     std::cin >> dato2;// recoge informacion


   // dato1 = 10;
  //  dato2 = 20;
    

    //suma
    resultado = dato1 + dato2;
    // muestra por pantalla 
    printf("%d + %d = %d\n", dato1, dato2, resultado);

    // resta
    resultado = dato1 - dato2;
     
    // muestra por pantalla
    printf("%d - %d = %d\n", dato1, dato2, resultado);

    // producto 
    resultado = dato1 * dato2;

    // muestra por pantalla
    printf("%d * %d = %d\n", dato1, dato2, resultado);

    // cociente
    resultado = dato1 / dato2;

    // muestra por pantalla
    printf("%d / %d = %d\n", dato1, dato2, resultado);

    std::cout << "Hola nundo!\n";
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
