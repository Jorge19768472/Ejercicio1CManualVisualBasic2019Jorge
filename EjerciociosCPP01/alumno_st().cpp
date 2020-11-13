#include "alumno_.st.h"


void menu_alumnos_st() {
    cout << "Usando estructuras" << endl;
    TipoAlumno unAlumno;
    unAlumno.edad = 25;
    alumno_cambia_edad(&unAlumno, 37);
    unAlumno.nombre = "Juan Francisco";
    unAlumno.notas[0] = 5.5;
    unAlumno.notas[1] = 7.5;
    mostrar_alumno_st(&unAlumno);
}
void mostrar_alumno_st(TipoAlumno* alumno) {
    cout << "Alumno: " << alumno->nombre << endl;
    cout << "  Edad: " << alumno->edad << endl;
}

void alumno_cambia_edad(TipoAlumno* ptr_alumno, int nuevaEdad) {
    ptr_alumno->edad = nuevaEdad;
    (*(ptr_alumno)).edad = nuevaEdad;   /// Igual que la anterior
    mostrar_alumno_st(ptr_alumno);
}
