#ifndef ALUMNO_ST_H_INCLUDED
#define ALUMNO_ST_H_INCLUDED

#include <iostream>
#include <string>

using namespace std;

struct TipoAlumno {
	string nombre;
	int edad;
	float notas[5];
};
void menu_alumnos_st();
void mostrar_alumno_st(TipoAlumno *unAlumno);
void alumno_cambia_edad(TipoAlumno *alumno, int nuevaEdad);

#endif
