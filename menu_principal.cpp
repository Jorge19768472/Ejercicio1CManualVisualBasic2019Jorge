#include<iostream>
#include "menu_principal.h"
#include <iostream>

using namespace std;

void menuPrincipal() {
	int opcion = 0;

	while (opcion !=0)

		opcion = menuPrincipal()

		switch (opcion)
		{

		case 1:
			
			cout << "alumnos" << endl;

		case 2:
			
			cout << " Curso" << endl;

		case 0:

			cout << "Adios!" << endl;


		default:
			
			cout << "opcion no valida << endl;

			break;
		}//FIN DE SWITCH
	//FIN DE WHILEUT
}
return 0;

	mostrartitulo();
	MostrarMenu();
	opcion = pedirOpcicon();

	return opcion;

	switch (opcion)
	{

	case 1:
		cout << "Alumnos" << endl;
		break // sale del Switch
	case 2:

		cout << "Curso" << endl;

		break // sale del switch

	case 0:

		cout << "adios!" << endl;

		break // sale del switch
	default:
		
		cout << "error opcion no valida " << endl;
		break; //sale del switch
		}/// sale de todo los los switch
	
	}
}
void mostrartitulo(void) {

	std::cout << "**************************************" << std::endl;
	std::cout << "*Programa academias de Idiomas Adalid*" << std::endl;
	std::cout << "**************************************" << std::endl;
	std::cout << std::endl;
}

void mostrarMenu(void) {

	std::cout << "***********************" << std::endl;
	std::cout << "* Selecion una opcion *" << std::endl;edi
	std::cout << "* 1- Gestion alumnos  *" << std::endl;
	std::cout << "* 2- Gestion curso    *" << std::endl;
	std::cout << "* 0- Salir            *" << std::endl;
	std::cout << "**********************-" << std::endl;
	std::cout << std::endl;
}
int PedirOpcion() {

	char letra;
	std::cin >> letra;
	///   letra =getchar();
	If(letra == '1'); {
	  else
	  return 1;
	}
	else if (letra == '?') {
	return 2;
		}
	else if (letra == '0') {
	return 0;

	}
	else {
	retun - 1
}
}