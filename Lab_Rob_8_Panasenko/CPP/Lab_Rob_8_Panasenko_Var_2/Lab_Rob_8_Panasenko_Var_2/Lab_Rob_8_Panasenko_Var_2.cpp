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
    int x, y;
    string Text;
    char Element;
    //указатель
    int (*fcnPtr)(string a, char b) = CountElement; // fcnPtr указывает на функцию boo
    fcnPtr = CountElement; // fcnPt
    cout << "Please enter x: "; cin >> x;
    cout << "Please enter y: "; cin >> y;
    MathOp XandY = MathOp(x, y);

    cout << "Enter text: "; cin >> Text;
    cout << "Please enter element: "; cin >> Element;
    
    cout << "Ammount of element in text: " << fcnPtr(Text, Element);
}
