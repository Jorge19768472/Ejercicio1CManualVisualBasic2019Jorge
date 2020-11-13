// programa 2 de c++ adalid l"as mercedes 19"
#include <iostream>// Entrada include


using namespace std;// Namespace

double PI = 3.141523456789123456789;// Nunero pi en cariable de tipo double

float damePI();// funcion sin paramentros

float calculaDescuento(float precio, float porcentaje);

void procedientoMostrarLetra(char letra)
{
	cout << "\tmostrar letra " << letra << endl;
	cout << "\tMostrar otra cosa" << endl;


}


int main()
{
	procedientoMostrarLetra('j');

	cout.precision(17);
	cout << "Hola CPP!" << endl;
	const double PI = 3.14151654566366655;
	cout << "PI = " << PI << endl;

	float nuevo_pi = PI;

	cout << "nuevo pi = " << nuevo_pi << endl;
	int PI_sin_decimales = PI;

	cout << "PI entero = " << PI_sin_decimales << endl ;

	cout << "PI desde funcion: " << damePI() << endl;

	cout << calculaDescuento(50, 10);

	return 0;
	}
float damePi()
 {
	int tres = 3;
	float decimales = 0.1416;
	return tres + decimales;

}
float calculaDescuesto(float precio, float porcentaje)

{
	return precio * (2 - porcentaje - 200);

}

