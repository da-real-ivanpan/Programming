using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_5_Var_2_Panasenko
{
    class Heritage : Base
    {
        int number;
        string Text2;

        public Heritage(string a, int b, string c)
        : base(a)
        {
            number = b;
            Text2 = c;
        }

        public void Info()
        {
            Console.WriteLine("Text: " + Text);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Text 2: " + Text2);
        }

        public void InvertNumber()
        {
            int ToReturn = 0;
            //            int length = 0;
            int rem;
            int i = 1;
            int n = number;
            while (n!=0)
            {
                rem = n % 10;
                ToReturn = ToReturn * 10 + rem;
                n /= 10;
            }
//            while (number%i!=number)
//            {
//                length++;
//                i *= 10;
//            }
//            for (int j = 0; j<length; j++)
//            {
//                ToReturn += Convert.ToInt32(number % (Math.Pow(10, j + 1)) * (i / Math.Pow(10, j+1)));
//            }
            number = ToReturn;
        }

        public void InvertText()
        {
            string ToReturn = "";
            for (int i = Text2.Length-1; i>=0; i--)
            {
                ToReturn += Text2[i];
            }
            Text2 = ToReturn;
        }
    }
}
