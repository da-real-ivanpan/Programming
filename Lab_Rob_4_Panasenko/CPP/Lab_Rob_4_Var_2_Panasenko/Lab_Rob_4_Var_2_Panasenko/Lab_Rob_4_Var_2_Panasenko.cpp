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

#include <iostream>

int main()
{
    Square K1 = Square();
    Square K2 = Square(0, 0, 20, 0, 20, 20, 0, 20);
    Square K3 = Square(K1);
    cout << "Sqaure K1: " << endl;
    K1.Info();
    cout << "Sqaure K2: " << endl;
    K2.Info();
    cout << "Sqaure K3: " << endl;
    K3.Info();
    K3 = K3 + 5;
    cout << "New square K3: " << endl;
    K3.Info();
    K1 = K2 / K3;
    cout << "New sqaure K1: " << endl;
    K1.Info();
}
