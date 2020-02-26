using System;

namespace Lab_Rob_1_Panasenko_Var_2
{
    class Program
    {
        //string convert_to_bin(int);
        static void Main(string[] args)
        {
            Console.Write("Enter number X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            string strX = Convert_to_bin(x);
            string strY = Convert_to_bin(y);

            Console.WriteLine("Binary of X: " + strX);
            Console.WriteLine("Binary of Y: " + strY);
            x = First(x);
            y = First(y);

            strX = Convert_to_bin(x);
            strY = Convert_to_bin(y);

            Console.WriteLine("New binary of X: " + strX);
            Console.WriteLine("New binary of Y: " + strY);

            if (Second(strX, strY) == true)
                Console.WriteLine("X equals to Y");
            else
                Console.WriteLine("X does not equal to Y");
        }

        public static string Convert_to_bin(int a)
        {
            int c = 0;
            string result = "";
            string temp = "";
            while (c != 1)
            {
                if (a <= 1)
                {
                    temp += a.ToString();
                    c = 1;
                }
                else
                {
                    temp += (a%2).ToString();
                    a = a/2;
                }
            }
            for (int i = temp.Length - 1; i >=0;i--)
            {
                result += temp[i];
            }
            return result;
        }

        public static int First(int a)
        {
            string str = Convert_to_bin(a);
            char[] ch = str.ToCharArray();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                if (ch[i] == '1')
                {
                    ch[i] = '0';
                    break;
                }
                else
                {
                    ch[i] = '1';
                }
            }
            str = new string(ch);
            int num = Convert.ToInt32(str);
            int rem, dec = 0, Base = 1;
            while (num > 0)
            {
                rem = num % 10;
                dec = dec + rem * Base;
                Base = Base * 2;
                num = num / 10;
            }
            return dec;
        }

        public static bool Second(string a, string b)
        {
            bool ToReturn = true;
            if (a.Length != b.Length)
            {
                string ToExtend = "";
                for (int i = 0; i < (Math.Abs((a.Length) - (b.Length))); i++)
                {
                    ToExtend += "0";
                }
                if ((a.Length) < (b.Length))
                {
                    ToExtend += a;
                    a = ToExtend;
                }
                else
                {
                    ToExtend += b;
                    b = ToExtend;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    ToReturn = false;
                    break;
                }
            }
            return (ToReturn);
        }
    }
}
