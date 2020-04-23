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
    try
    {
        Square K1 = Square();
        Square K2 = Square(0, 0, 26, 0, 20, 20, 0, 20);
        Square K3 = Square(K1);
        if (sqrt(pow(double(K1.dot1[1] - K1.dot1[0]), 2) + pow(double(K1.dot2[1] - K1.dot2[0]), 2)) !=
            sqrt(pow(double(K1.dot2[1] - K1.dot2[0]), 2) + pow(double(K1.dot3[1] - K1.dot3[0]), 2)) ||
            sqrt(pow(double(K1.dot2[1] - K1.dot2[0]), 2) + pow(double(K1.dot3[1] - K1.dot3[0]), 2)) !=
            sqrt(pow(double(K1.dot3[1] - K1.dot3[0]), 2) + pow(double(K1.dot4[1] - K1.dot4[0]), 2)) ||
            sqrt(pow(double(K1.dot3[1] - K1.dot3[0]), 2) + pow(double(K1.dot4[1] - K1.dot4[0]), 2)) !=
            sqrt(pow(double(K1.dot4[1] - K1.dot4[0]), 2) + pow(double(K1.dot1[1] - K1.dot1[0]), 2)))
        {
            throw new LengthException();
        }
        cout << "Sqaure K1: " << endl;
        K1.Info();
        if (sqrt(pow(double(K2.dot1[1] - K2.dot1[0]), 2) + pow(double(K2.dot2[1] - K2.dot2[0]), 2)) !=
            sqrt(pow(double(K2.dot2[1] - K2.dot2[0]), 2) + pow(double(K2.dot3[1] - K2.dot3[0]), 2)) ||
            sqrt(pow(double(K2.dot2[1] - K2.dot2[0]), 2) + pow(double(K2.dot3[1] - K2.dot3[0]), 2)) !=
            sqrt(pow(double(K2.dot3[1] - K2.dot3[0]), 2) + pow(double(K2.dot4[1] - K2.dot4[0]), 2)) ||
            sqrt(pow(double(K2.dot3[1] - K2.dot3[0]), 2) + pow(double(K2.dot4[1] - K2.dot4[0]), 2)) !=
            sqrt(pow(double(K2.dot4[1] - K2.dot4[0]), 2) + pow(double(K2.dot1[1] - K2.dot1[0]), 2)))
        {
            throw LengthException();
        }
        cout << "Sqaure K2: " << endl;
        K2.Info();
        if (sqrt(pow(double(K3.dot1[1] - K3.dot1[0]), 2) + pow(double(K3.dot2[1] - K3.dot2[0]), 2)) !=
            sqrt(pow(double(K3.dot2[1] - K3.dot2[0]), 2) + pow(double(K3.dot3[1] - K3.dot3[0]), 2)) ||
            sqrt(pow(double(K3.dot2[1] - K3.dot2[0]), 2) + pow(double(K3.dot3[1] - K3.dot3[0]), 2)) !=
            sqrt(pow(double(K3.dot3[1] - K3.dot3[0]), 2) + pow(double(K3.dot4[1] - K3.dot4[0]), 2)) ||
            sqrt(pow(double(K3.dot3[1] - K3.dot3[0]), 2) + pow(double(K3.dot4[1] - K3.dot4[0]), 2)) !=
            sqrt(pow(double(K3.dot4[1] - K3.dot4[0]), 2) + pow(double(K3.dot1[1] - K3.dot1[0]), 2)))
        {
            throw new LengthException();
        }
        cout << "Sqaure K3: " << endl;
        K3.Info();
        K3 = K3 + 5;
        cout << "New square K3: " << endl;
        K3.Info();
        K1 = K2 / K3;
        cout << "New sqaure K1: " << endl;
        K1.Info();
    }
    catch (LengthException& e)
    {
        cout << "I don't know how but you managed to mess up the square. Check the dots.";
    }
}