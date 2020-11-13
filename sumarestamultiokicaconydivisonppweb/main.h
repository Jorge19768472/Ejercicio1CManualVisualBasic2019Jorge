#pragma once
#include <iostream>
using namespace std;

main()
{
	float x, y, s, r, p, d;
	cout<< "\n ingrese numero x: ";
	cin >> x;
	cout << "\n ingrese numero y: ";
	cin >> y;
	s = x + y;
	r = x - y;
	p = x * y;
	d = x / y;
	cout << x << " + " << y << " = " << s;

	cout << x << " - " << y << " = " << r;
	cout << x << " * " << y << " = " << p;
	cout << x << " / " << y << " = " << d;

	return 0;


}



