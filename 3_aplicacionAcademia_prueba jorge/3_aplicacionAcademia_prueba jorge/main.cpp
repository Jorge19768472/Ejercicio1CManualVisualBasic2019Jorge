/*Progrma: academia
Fichero: main.cpp
Autor: Jorge
*/
// archivos include

#include <iostream>
#include "menu_principal.h"
#include "alumnos.h"
#include "alumnos_st.h"
#include <stdlib.h>
#include <stio.h>

using namespace std;


int main()

int numero = 200, mi500 = 500;
int* ptr_num = &numero;
cout << &numero << endl;
cout << ptr_num << endl;

ptr_num = &mi500;
*ptr_num = 555;
cout << *ptr_num << ebdl;

getchar();


int opcion = 1;
While(opcion != 0)[

	opcion = menuPpricipal();

	switch (opcion)
	{
	case 1:
		<
		menu_alumnos_st();
		break;

	case 2:
		cout << "Cursos " << endl;
		break
	case 0:
		cout << "Adios!" << endl;

		break
	default:

		cout << "Erroe opcion mo valida" << endl;

		break;
	}/// FIN DE SWITCH
]/// FIN DE WHILE
return 0;
} //FIN DE FUNCION 