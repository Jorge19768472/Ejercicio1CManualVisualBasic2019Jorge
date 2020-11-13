// cubocpp.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//
// Usamos la funcion inline para calcular el vomun de un cubo

#include <iostream>

inline float cubo(const float s) {// Instruccon para hacer la cubo
    return s * s * s; // devulve la multiplicacion 

}
int main()
{
    //al no utlizar using namesoace std; tengo que utilizar std:: y luego el alamento 
    std::cout << "Introoduce la longitud del lado del cubo: \n";
    float lado; // declaracion de valriable
   std:: cin >> lado; // recoge el valor
   std::cout << "el volumen del cubo de lado: " // muestra el resultado 
       << lado << " es " << cubo(lado) << '\n';
   return 0; //  devuelve cero si todo da igual



}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
