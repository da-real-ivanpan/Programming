#include "Header.h"

int CountElement(string text, char a)
{
	int count = 0;
	for (int i = 0; i <= text.length(); i++)
	{
		if (text[i] == a)
			count++;
	}
	return count;
}