using System;

namespace Lab_Rob_3_Var_2_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Massive arr = new Massive();
            arr.ShowAndTell();
            Console.WriteLine();
            Console.WriteLine("Ammount of Glasnih: " + arr.GetAmmount);
            Console.WriteLine(arr.GetElement);
        }
    }
}
