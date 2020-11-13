#include "principal.h"
#include <iostream>
using namespace std;

main()
{	float x, y, s, r, p, d;
	cout << "\n ingrese numero x: ";
	cin >> x;
	cout << "\n ingrese numero y: ";
	cin >> y;
	s = x + y;
	r = x - y;
	p = x * y;
	d = x / y;
	cout <<"\n"<< x << " + " <<y << y << " = " << s ;
	cout <<"\n"<< x << " - " <<y << y << " = " << r ;
	cout <<"\n" << x << " * " << y << y << " = " << p;
	cout << "\n" << x << " / " << y << y << " = " << d;
	return 0;	

}