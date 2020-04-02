using System;

namespace Lab_Rob_4_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Square K1 = new Square();
            Square K2 = new Square(0, 0, 20, 0, 20, 20, 0, 20);
            Square K3 = new Square(K1);
            Console.WriteLine("Square K1:");
            K1.Info();
            Console.WriteLine("Square K2:");
            K2.Info();
            Console.WriteLine("Square K3:");
            K3.Info();
            K3 = K3 + 5;
            Console.WriteLine("New square K3:");
            K3.Info();
            K1 = K2 / K3;
            Console.WriteLine("New square K1:");
            K1.Info();
        }
    }
}
