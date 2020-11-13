#pragma once
#include "menu_principal.h"

using namespace std;

int menuPrincipal() {
	
	int opcion = 0;
	mostrarTitulo();
	mostrarMenu();
	opcion = PedirOpcion();
	return 0

}
void mostrarTitulo(void) {
	std::cout << "**************************************" << std::endl;
	std::cout << " Programa Academia de Idiomas Adalid " << std::endl;
	std::cout << "**************************************" << std::endl;
}
void mostrarMenu(void) {
    std::cout << "*************************" << std::endl;
    std::cout << "* Seleccione una opcion *" << std::endl;
    std::cout << "* 1 - Gestion alumnos   *" << std::endl;
    std::cout << "* 2 - Gestion cursos    *" << std::endl;
    std::cout << "* 0 - Salir             * " << std::endl;
    std::cout << "*************************" << std::endl;
    std::cout << std::endl;
}
int pedirOpcion() {
    char letra;
    std::cin >> letra;
    if (letra == '1') {
        return 1;
    }
    else if (letra == '2') {
        return 2;
    }
    else if (letra == '0') {
        return 0;
    }
    else {
        return -1;
    }
}
