// Lab_Rob_6_Panasenko_Var_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Header.h"

int main()
{
    int am[10];
    int cm[10];
    int dm[10];
    double resultm[10];

    for (int i = 0; i < 10; i++)
    {
        am[i] = (rand() % 10) - 10;
        cm[i] = (rand() % 10) - 10;
        dm[i] = (rand() % 10) - 10;
        Class Temp = Class(am[i], cm[i], dm[i]);
        resultm[i] = Temp.result;
        cout << "i = " << i << ", a = " << am[i] << ", c = " << cm[i] << ", d = " << dm[i] << ", f(a, c, d) = " << resultm[i] << endl;
    }
}
