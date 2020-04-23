using System;

namespace Lab_Rob_6_Panasenko_Var_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] am = new int[10];
            int[] cm = new int[10];
            int[] dm = new int[10];
            double[] resultm = new double[10];
            Random rnd = new Random();

            for (int i = 0; i<10; i++)
            {
                am[i] = rnd.Next(-10, 11);
                cm[i] = rnd.Next(-10, 11);
                dm[i] = rnd.Next(-10, 11);
                Class tempClass = new Class(am[i], cm[i], dm[i]);
                resultm[i] = tempClass.result;
                Console.WriteLine("i = " + i + ", a = " + am[i] + ", c = " + cm[i] + ", d = " + dm[i] + ", f(a, c, d) = " + resultm[i]);
            }

        }
    }
}
