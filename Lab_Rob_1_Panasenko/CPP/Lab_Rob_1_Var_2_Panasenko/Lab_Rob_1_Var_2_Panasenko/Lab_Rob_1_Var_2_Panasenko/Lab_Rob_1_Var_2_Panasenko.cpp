#include <iostream>
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <string>
#include <iterator>
#include "Header.h"
#include <vector>
using namespace std;

int main()
{
	int x;
	cout << "Enter number X: "; cin >> x;
	int y;
	cout << "Enter number Y: "; cin >> y;
	string strX = convert_to_bin(x);
	string strY = convert_to_bin(y);
	int* intX = convert_to_bin_int(x);
	int* intY = convert_to_bin_int(y);
	int xlength = get_length(x);
	int ylength = get_length(y);
	int intXone = 0;
	int intYone = 0;
	for (int i = 0; i < xlength; i++)
		intXone += intX[i] * int(pow(10, i));
	for (int i = 0; i < ylength; i++)
		intYone += intY[i] * int(pow(10, i));
	cout << "Binary of X: " << intXone << endl;
	cout << "Binary of Y: " << intYone << endl;
//	x = First(x);
//	y = First(y);
	intX = First_int(intX, xlength);
	intY = First_int(intY, ylength);
	intXone = 0;
	intYone = 0;
	for (int i = 0; i < xlength; i++)
		intXone += intX[i] * int(pow(10, i));
	for (int i = 0; i < ylength; i++)
		intYone += intY[i] * int(pow(10, i));
//CONVERTING TO DECIMAL
	int remx, remy, decX = 0, decY = 0, b = 1;
	int tempX = intXone;
	while (tempX > 0)
	{
		remx = tempX % 10;
		decX = decX + remx * b;
		b *= 2;
		tempX /= 10;
	}
	int tempY = intYone;
	b = 1;
	while (tempY > 0)
	{
		remy = tempY % 10;
		decY = decY + remy * b;
		b *= 2;
		tempY /= 10;
	}

	cout << "New value of X: " <<  decX << endl;
	cout << "New value of Y: " <<  decY << endl;

	strX = convert_to_bin(x);
	strY = convert_to_bin(y);

	cout << "New binary of X: " << intXone << endl;
	cout << "New binary of Y: " << intYone << endl;

	if (Second(intXone, intYone, xlength, ylength) == true)
	{
		cout << "X equals to Y";
	}
	else
	{
		cout << "X does not equal to Y";
	}
	cout << endl;
}