#include <iostream>
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <string>
#include <iterator>
#include "Header.h"
using namespace std;

int main()
{
	int x;
	cout << "Enter number X: "; cin >> x;
	int y;
	cout << "Enter number Y: "; cin >> y;
	string strX = convert_to_bin(x);
	string strY = convert_to_bin(y);

	cout << "Binary of X: " << strX << endl;
	cout << "Binary of Y: " << strY << endl;
	x = First(x);
	y = First(y);
	cout << "New value of X: " << x << endl;
	cout << "New value of Y: " << y << endl;

	strX = convert_to_bin(x);
	strY = convert_to_bin(y);

	cout << "New binary of X: " << strX << endl;
	cout << "New binary of Y: " << strY << endl;

	if (Second(strX, strY) == true)
	{
		cout << "X equals to Y";
	}
	else
	{
		cout << "X does not equal to Y";
	}
	cout << endl;
}