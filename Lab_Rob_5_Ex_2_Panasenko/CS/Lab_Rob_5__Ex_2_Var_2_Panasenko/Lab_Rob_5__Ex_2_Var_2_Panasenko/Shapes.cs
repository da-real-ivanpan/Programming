using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_5__Ex_2_Var_2_Panasenko
{
    class Shapes
    {
        public virtual double ScaleTri(int a, int b, int c)
        {
            double temp = (a + b + c) / 2;
            return (Math.Sqrt(temp * (temp - a) * (temp - b) * (temp - c)));
        }

        public virtual double ScaleCir(int r)
        {
            return (Math.PI * r);
        }

        public virtual int PerTri(int a, int b, int c)
        {
            return (a + b + c);
        }

        public virtual double PerCir(int r)
        {
            return (2 * Math.PI * r);
        }
    }
}
