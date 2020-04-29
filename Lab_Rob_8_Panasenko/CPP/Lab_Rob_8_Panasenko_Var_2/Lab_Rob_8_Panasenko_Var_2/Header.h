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

int CountElement(string, char);

class MathOp
{
public:
	int x, y;
	int sum;
	int dif;
	int mult;
	int divide;
	int whatleft;

	MathOp(int a, int b)
	{
		x = a;
		y = b;
		sum = a + b;
		dif = abs(a - b);
		mult = a * b;
		divide = a / b;
		whatleft = a % b;
	}

	void info()
	{
		cout << "Operations with numbers:";
		cout << x << " + " << y << " = " << sum;
		cout << "| " << x << " - " << y << " | = " << dif;
		cout << x << " * " << y << " = " << mult;
		cout << x << " / " << y << " = " << divide;
		cout << x << " % " << y << " = " << whatleft;
	}
};