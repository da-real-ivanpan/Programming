using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_6_Panasenko_Var_2
{
    class Class
    {
        int a;
        int c;
        int d;
        public double result;

        public Class(int at, int ct, int dt)
        {
            a = at;
            c = ct;
            d = dt;
            //getACD();
            result = GetResult(a, c, d);
        }

        public Class()
        {
            getACD();
            result = GetResult(a, c, d);
        }

        public void getACD()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());
        }

        public double GetResult(int at, int ct, int dt)
        {
            if (at/4 + ct == 0)
                throw new System.DivideByZeroException();
            else
                return ((Math.Log(2 * ct - at) + dt - 152) / (at / 4 + ct));
        }

    }
}
