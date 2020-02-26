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
	x = x - 1;
	return x;
}

bool Second(int a, int b)
{
	if (a == b)
	{
		return true;
	}
	else
	{
		return false;
	}
}