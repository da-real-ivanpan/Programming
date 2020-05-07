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
#include <math.h>
#define _USE_MATH_DEFINES
using namespace std;

class Shapes
{
public:
    virtual double ScaleTri(int a, int b, int c)
    {
        double temp = (a + b + c) / 2;
        return (sqrt(temp*(temp - a)*(temp - b)*(temp-c)));
    }

    virtual double ScaleCir(int r)
    {
        return (M_PI * r);
    }

    virtual int PerTri(int a, int b, int c)
    {
        return (a + b + c);
    }

    virtual double PerCir(int r)
    {
        return (2 * M_PI * r);
    }
};

class Triangle : public Shapes
{
public:
    int a, b, c;

    Triangle(int a1, int b1, int c1)
    {
        a = a1;
        b = b1;
        c = c1;
    }
    double ScaleTri(int a, int b, int c) override
    {
        double temp = (a + b + c) / 2;
        return (sqrt(temp * (temp - a) * (temp - b) * (temp - c)));
    }
    int PerTri(int a, int b, int c) override
    {
        return (a + b + c);
    }
};

class Circle : public Shapes
{
public:
    int r;

    Circle(int r1)
    {
        r = r1;
    }

    double PerCir(int r) override
    {
        return (2 * M_PI * r);
    }

    double ScaleCir(int r) override
    {
        return (M_PI * r);
    }
};