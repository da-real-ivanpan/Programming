using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_5__Ex_2_Var_2_Panasenko
{
    class Circle: Shapes
    {
        int r;

        public Circle(int r1)
        {
            r = r1;
        }

        public override double PerCir(int r)
        {
            return base.PerCir(r);
        }

        public override double ScaleCir(int r)
        {
            return base.ScaleCir(r);
        }
    }
}
