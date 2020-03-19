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
            Console.WriteLine("Attemppting to show elements without function: ");
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4] + " " + arr[5] + " " + arr[6] + " " + arr[7] + " " + arr[8] + " " + arr[9]);
//            Console.WriteLine(Convert.ToString(arr.GetElement()));
        }
    }
}
