using System;

namespace Lab_Rob_4_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Square K1 = new Square();
                Square K2 = new Square(0, 0, 30, 0, 20, 20, 0, 20);
                Square K3 = new Square(K1);
                Console.WriteLine("Square K1:");
                if (Math.Sqrt(Math.Pow(Convert.ToDouble(K1.dot1[1] - K1.dot1[0]), 2) + Math.Pow(Convert.ToDouble(K1.dot2[1] - K1.dot2[0]), 2)) !=
                    Math.Sqrt(Math.Pow(Convert.ToDouble(K1.dot2[1] - K1.dot2[0]), 2) + Math.Pow(Convert.ToDouble(K1.dot3[1] - K1.dot3[0]), 2)) ||
                    Math.Sqrt(Math.Pow(Convert.ToDouble(K1.dot2[1] - K1.dot2[0]), 2) + Math.Pow(Convert.ToDouble(K1.dot3[1] - K1.dot3[0]), 2)) !=
                    Math.Sqrt(Math.Pow(Convert.ToDouble(K1.dot3[1] - K1.dot3[0]), 2) + Math.Pow(Convert.ToDouble(K1.dot4[1] - K1.dot4[0]), 2)) ||
                    Math.Sqrt(Math.Pow(Convert.ToDouble(K1.dot3[1] - K1.dot3[0]), 2) + Math.Pow(Convert.ToDouble(K1.dot4[1] - K1.dot4[0]), 2)) !=
                    Math.Sqrt(Math.Pow(Convert.ToDouble(K1.dot4[1] - K1.dot4[0]), 2) + Math.Pow(Convert.ToDouble(K1.dot1[1] - K1.dot1[0]), 2)))
                {
                    throw new LengthException("Oh");
                }
                K1.Info();
                Console.WriteLine("Square K2:");
                if (Math.Sqrt(Math.Pow(Convert.ToDouble(K2.dot1[1] - K2.dot1[0]), 2) + Math.Pow(Convert.ToDouble(K2.dot2[1] - K2.dot2[0]), 2)) !=
        Math.Sqrt(Math.Pow(Convert.ToDouble(K2.dot2[1] - K2.dot2[0]), 2) + Math.Pow(Convert.ToDouble(K2.dot3[1] - K2.dot3[0]), 2)) ||
        Math.Sqrt(Math.Pow(Convert.ToDouble(K2.dot2[1] - K2.dot2[0]), 2) + Math.Pow(Convert.ToDouble(K2.dot3[1] - K2.dot3[0]), 2)) !=
        Math.Sqrt(Math.Pow(Convert.ToDouble(K2.dot3[1] - K2.dot3[0]), 2) + Math.Pow(Convert.ToDouble(K2.dot4[1] - K2.dot4[0]), 2)) ||
        Math.Sqrt(Math.Pow(Convert.ToDouble(K2.dot3[1] - K2.dot3[0]), 2) + Math.Pow(Convert.ToDouble(K2.dot4[1] - K2.dot4[0]), 2)) !=
        Math.Sqrt(Math.Pow(Convert.ToDouble(K2.dot4[1] - K2.dot4[0]), 2) + Math.Pow(Convert.ToDouble(K2.dot1[1] - K2.dot1[0]), 2)))
                {
                    throw new LengthException("Oh");
                }
                K2.Info();
                if (Math.Sqrt(Math.Pow(Convert.ToDouble(K3.dot1[1] - K3.dot1[0]), 2) + Math.Pow(Convert.ToDouble(K3.dot2[1] - K3.dot2[0]), 2)) !=
        Math.Sqrt(Math.Pow(Convert.ToDouble(K3.dot2[1] - K3.dot2[0]), 2) + Math.Pow(Convert.ToDouble(K3.dot3[1] - K3.dot3[0]), 2)) ||
        Math.Sqrt(Math.Pow(Convert.ToDouble(K3.dot2[1] - K3.dot2[0]), 2) + Math.Pow(Convert.ToDouble(K3.dot3[1] - K3.dot3[0]), 2)) !=
        Math.Sqrt(Math.Pow(Convert.ToDouble(K3.dot3[1] - K3.dot3[0]), 2) + Math.Pow(Convert.ToDouble(K3.dot4[1] - K3.dot4[0]), 2)) ||
        Math.Sqrt(Math.Pow(Convert.ToDouble(K3.dot3[1] - K3.dot3[0]), 2) + Math.Pow(Convert.ToDouble(K3.dot4[1] - K3.dot4[0]), 2)) !=
        Math.Sqrt(Math.Pow(Convert.ToDouble(K3.dot4[1] - K3.dot4[0]), 2) + Math.Pow(Convert.ToDouble(K3.dot1[1] - K3.dot1[0]), 2)))
                {
                    throw new LengthException("Oh");
                }
                Console.WriteLine("Square K3:");
                K3.Info();
                K3 = K3 + 5;
                Console.WriteLine("New square K3:");
                K3.Info();
                K1 = K2 / K3;
                Console.WriteLine("New square K1:");
                K1.Info();
            }
            catch(LengthException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
