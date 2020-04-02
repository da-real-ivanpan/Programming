#include <iostream>
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <string>
#include <iterator> 
#include <sstream> 
#include"Header.h"
using namespace std;

int main()
{
    Base FirsClass = Base("Sample text is always fun!");
    Heritage SecondClass = Heritage("Text from Base is always fun!", 123456789, "Text from Heritage is very different");
    cout << "Original input: ";
    SecondClass.Info();
    cout << "Length of Text: " << SecondClass.GetLenth();
    SecondClass.InvertText();
    SecondClass.InvertNumber();
    cout << "New output: ";
    SecondClass.Info();
    cout << "Length of Text: " << SecondClass.GetLenth();
}

