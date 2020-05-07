using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_5__Ex_2_Var_2_Panasenko
{
    class Triangle : Shapes
    {
        int a, b, c;

        public Triangle (int a1, int b1, int c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public override double ScaleTri(int a, int b, int c)
        {
            return base.ScaleTri(a, b, c);
        }
        public override int PerTri(int a, int b, int c)
        {
            return base.PerTri(a, b, c);
        }
    }
}
