#pragma once
#include <iostream>
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <string>
#include <iterator> 
#include <sstream> 
#include <iomanip>
using namespace std;

class Class
{
private:
	int a;
	int c;
	int d;

public:
	double result;

	Class(int at, int ct, int dt)
	{
		a = at;
		c = ct;
		d = dt;

		result = GetResult(a, c, d);
	}

	Class()
	{
		getACD();
		result = GetResult(a, c, d);
	}

	void getACD()
	{
		cout << "Enter a: "; cin >> a;
		cout << "Enter c: "; cin >> c;
		cout << "Enter d: "; cin >> d;
	}

	double GetResult(int at, int ct, int dt)
	{
		if (at / 4 + ct == 0)
			throw "Division by zero!";
		else
			return((log(2 * ct - at) + dt - 152) / (at / 4 + ct));
	}
};