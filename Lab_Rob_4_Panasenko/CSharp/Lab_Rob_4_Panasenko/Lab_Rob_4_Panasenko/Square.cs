using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_4_Panasenko
{
    class Square
    {
        public double[] dot1 { get; set; }
        public double[] dot2 { get; set; }
        public double[] dot3 { get; set; }
        public double[] dot4 { get; set; }
        double edge { get; set; }

        public Square()
        {
            dot1 = new double[2] { 0, 0 };
            dot2 = new double[2] { 5, 0 };
            dot3 = new double[2] { 5, 5 };
            dot4 = new double[2] { 0, 5 };
            edge = Math.Sqrt(Math.Pow(Convert.ToDouble(dot1[1] - dot1[0]), 2) + Math.Pow(Convert.ToDouble(dot2[1] - dot2[0]), 2));
        }

        public Square(double a1, double a2, double b1, double b2, double c1, double c2, double d1, double d2)
        {
            dot1 = new double[2] { a1, a2 };
            dot2 = new double[2] { b1, b2 };
            dot3 = new double[2] { c1, c2 };
            dot4 = new double[2] { d1, d2 };
            edge = Math.Sqrt(Math.Pow(Convert.ToDouble(dot1[1] - dot1[0]), 2) + Math.Pow(Convert.ToDouble(dot2[1] - dot2[0]), 2));
        }

        public Square (Square previousSquare)
        {
            dot1 = previousSquare.dot1;
            dot2 = previousSquare.dot2;
            dot3 = previousSquare.dot3;
            dot4 = previousSquare.dot4;
            edge = previousSquare.edge;
        }

        public double Area()
        {
            double Area = Math.Pow(edge, 2);
            return Area;
        }

        public double Perimeter()
        {
            double P = edge * 4;
            return P;
        }

        public void Info()
        {
            Console.WriteLine("Edge of square: " + Convert.ToString(edge));
            Console.WriteLine("Area of square: " + Convert.ToString(Area()));
            Console.WriteLine("Perimeter of square: " + Convert.ToString(Perimeter()));
        }

        public static Square operator / (Square K1, Square K2)
        {
 //           double Dif = K1.edge / K2.edge;
            Square NewK = new Square(K1.dot1[0], K1.dot1[1], K1.dot2[0]/K2.dot2[0], K1.dot2[1], K1.dot3[0]/K2.dot3[0], K1.dot3[1]/K2.dot3[1], K1.dot4[0], K1.dot4[1]/K1.dot4[1]);
            return NewK;
        }

        public static Square operator + (Square K1, int a)
        {
//            K1.dot2[0] += a;
//            K1.dot3[0] += a;
//            K1.dot3[1] += a;
//            K1.dot4[1] += a;
            Square NewK = new Square(K1.dot1[0], K1.dot1[1], K1.dot2[0] + a, K1.dot2[1], K1.dot3[0] + a, K1.dot3[1] + a, K1.dot4[0], K1.dot4[1] + a); ;
            return NewK;
        }
    }
}
