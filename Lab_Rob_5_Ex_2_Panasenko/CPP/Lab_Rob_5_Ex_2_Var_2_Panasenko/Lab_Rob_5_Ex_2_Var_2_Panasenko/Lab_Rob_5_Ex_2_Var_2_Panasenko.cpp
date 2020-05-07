#include <iostream>
#include <stdio.h>
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <string>
#include <iterator> 
#include <sstream> 
#include <math.h>
#define _USE_MATH_DEFINES
#include"Header.h"
//using namespace std;

int main()
{
    std::cout << "Hello World!\n";
    Triangle Tri = Triangle(3, 4, 5);
    Circle C = Circle(12);
    cout << "Scale of Triangle: " << Tri.ScaleTri(3, 4, 5) << endl;
    cout << "Perimeterof Triangle: " << Tri.PerTri(3, 4, 5) << endl;
    cout << "Scale of Circle: " << C.ScaleCir(12) << endl;
    cout << "Perimeter of Circle: " << C.PerCir(12) << endl;
}