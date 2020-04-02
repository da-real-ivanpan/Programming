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

class Base
{
public:
	string Text;
	
	Base(string a)
	{
		this->Text = a;
	}

	int GetLenth()
	{
		return Text.length();
	}
};

class Heritage : public Base
{
	int number;
	string Text2;

public:
	Heritage(string a, int b, string c)
		: Base(a)
	{
//		this->Text = a;
		this->number = b;
		this->Text2 = c;
	}

	void Info()
	{
		cout << "Text: " << Text << endl;
		cout << "Number: " << number << endl;
		cout << "Text 2: " << Text2 << endl;
	}

	void InvertNumber()
	{
		int ToReturn = 0;
		int rem;
		int n = number;
		while (n != 0)
		{
			rem = n % 10;
			ToReturn = ToReturn * 10 + rem;
			n /= 10;
		}
		number = ToReturn;
	}

	void InvertText()
	{
		string ToReturn = "";
		for (int i = int(Text2.length()) - 1; i >= 0; i--)
		{
			ToReturn += Text2[i];
		}
		Text2 = ToReturn;
	}
};