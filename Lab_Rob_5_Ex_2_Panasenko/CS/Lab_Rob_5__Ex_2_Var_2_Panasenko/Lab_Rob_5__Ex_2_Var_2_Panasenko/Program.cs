using System;

namespace Lab_Rob_5__Ex_2_Var_2_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangle Tri = new Triangle(3, 4, 5);
            Circle C = new Circle(12);
            Console.WriteLine("Scale of Triangle: " + Tri.ScaleTri(3, 4, 5));
            Console.WriteLine("Perimeter of Triangle: " + Tri.PerTri(3, 4, 5));
            Console.WriteLine("Scale of Circle: " + C.ScaleCir(12));
            Console.WriteLine("Perimeter of Circle: " + C.PerCir(12));
        }
    }
}
