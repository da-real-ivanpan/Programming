#include "Header.h"

string convert_to_bin(int a)
{
	int c = 0;
	string result = "";
	string temp = "";
	while (c != 1)
	{
		if (a <= 1)
		{
			temp += std::to_string(a);
			c = 1;
		}
		else
		{
			temp += std::to_string(a % 2);
			a = a / 2;
		}
	}
	for (int i = temp.length() - 1; i >= 0; i--)
	{
		result += temp[i];
	}
	return result;
}

int& First(int &x)
{
	string str = convert_to_bin(x);
	for (int i = str.length() - 1; i >= 0; i--)
	{
		if (str[i] == '1')
		{
			str[i] = '0';
			break;
		}
		else
		{
			str[i] = '1';
		}
	}
	int num = std::stoi(str);
	int rem, dec=0, base = 1;
	while (num > 0)
	{
		rem = num % 10;
		dec = dec + rem * base;
		base = base * 2;
		num = num / 10;
	}
	return dec;
}

bool Second(string a, string b)
{
	bool ToReturn = true;
	if (a.length() != b.length())
	{
		string ToExtend = "";
		for (int i = 0; i < int(abs(int(a.length()) - int(b.length()))); i++)
		{
			ToExtend += "0";
		}
		if (int(a.length()) < int(b.length()))
		{
			ToExtend += a;
			a = ToExtend;
		}
		else
		{
			ToExtend += b;
			b = ToExtend;
		}
	}
	for (int i = 0; i < int(a.length()); i++)
	{
		if (a[i] != b[i])
		{
			ToReturn = false;
			break;
		}
	}
	return(ToReturn);
}