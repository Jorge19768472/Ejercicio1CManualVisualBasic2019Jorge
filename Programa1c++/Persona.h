#pragma once
// Progrmama adalid y formacion y empleo Las Mercedes  19 
//  Archvo personas.h
#ifndef PERSONA_H
#define PERSONA_H

class  Personas
{
public:
	 Personas(); ///Conructores
	~ Personas(string nom, int ed);//Contructor
	void mostrar();

	/// Metodos de acceso inline:
	int gwtEdad()
	{
		return this->edad;

	}
	/// Metodo de modificacion
	String getNombre()
	{
		return this->nombre;

	}
	/// Mrtodo de modificacion
	void SetEdad(int edad)
	{
		this->edad =edad;

	}
	-Personas();


private:
	string nombre;
	int edad;

};
#endif


 Personas:: Personas()
{
}

 Personas::~ Personas()
{
}