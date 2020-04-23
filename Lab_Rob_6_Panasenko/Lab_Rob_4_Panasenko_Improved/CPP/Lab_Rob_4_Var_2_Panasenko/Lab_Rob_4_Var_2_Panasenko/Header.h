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

class Square
{	

public:
	double dot1[2], dot2[2], dot3[2], dot4[2];
	double edge;

	Square()
	{
		dot1[0] = 0;
		dot1[1] = 0;
		dot2[0] = 5;
		dot2[1] = 0;
		dot3[0] = 5;
		dot3[1] = 5;
		dot4[0] = 0;
		dot4[1] = 5;
		edge = sqrt(pow(dot1[1] - dot1[0], 2) + pow(dot2[1] - dot2[0], 2));
	}

	Square(double a1, double a2, double b1, double b2, double c1, double c2, double d1, double d2)
	{
		dot1[0] = a1;
		dot1[1] = a2;
		dot2[0] = b1;
		dot2[1] = b2;
		dot3[0] = c1;
		dot3[1] = c2;
		dot4[0] = d1;
		dot4[1] = d2;
		edge = sqrt(pow(dot1[1] - dot1[0], 2) + pow(dot2[1] - dot2[0], 2));
	}

	Square(const Square &previousSquare)
	{
		dot1[0] = previousSquare.dot1[0];
		dot1[1] = previousSquare.dot1[1];
		dot2[0] = previousSquare.dot2[0];
		dot2[1] = previousSquare.dot2[1];
		dot3[0] = previousSquare.dot3[0];
		dot3[1] = previousSquare.dot3[1];
		dot4[0] = previousSquare.dot4[0];
		dot4[1] = previousSquare.dot4[1];
		edge = previousSquare.edge;
	}

	double Area()
	{
		double Area = pow(edge, 2);
		return Area;
	}

	double Perimeter()
	{
		double P = edge * 4;
		return P;
	}

	void Info()
	{
		cout << "Edge of square: " << edge << endl;
		cout << "Area of square: " << Area() << endl;
		cout << "Perimeter of square: " << Perimeter() << endl;
	}

	
};

struct LengthException : public exception
{
	const char* what() const throw ()
	{
		return "C++ Exception";
	}
};

Square operator / (Square, Square);
Square operator + (Square, int);

//class Square
//{
//public:
//	double[] dot1;
//};