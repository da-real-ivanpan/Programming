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
            int[] intX = convert_to_bin_int(x);
            int[] intY = convert_to_bin_int(y);
            int intXone = 0;
            int intYone = 0;
            for (int i = 0; i < intX.Length; i++)
                intXone += intX[i] * Convert.ToInt32(Math.Pow(10, i));
            for (int i = 0; i < intY.Length; i++)
                intYone += intY[i] * Convert.ToInt32(Math.Pow(10, i));
            Console.WriteLine("Binary of X: " + intXone);
            Console.WriteLine("Binary of Y: " + intYone);
            x = First(x);
            y = First(y);
            intX = First_int(intX, intX.Length);
            intY = First_int(intY, intY.Length);
            intXone = 0;
            intYone = 0;
            for (int i = 0; i < intX.Length; i++)
                intXone += intX[i] * Convert.ToInt32(Math.Pow(10, i));
            for (int i = 0; i < intY.Length; i++)
                intYone += intY[i] * Convert.ToInt32(Math.Pow(10, i));
            Console.WriteLine("New value of X: " + Convert.ToInt32(Convert.ToString(intXone), 2).ToString());
            Console.WriteLine("New value of Y: " + Convert.ToInt32(Convert.ToString(intYone), 2).ToString());

            strX = Convert_to_bin(x);
            strY = Convert_to_bin(y);

            Console.WriteLine("New binary of X: " + intXone);
            Console.WriteLine("New binary of Y: " + intYone);

            if (Second(intXone, intYone, intX.Length, intY.Length) == true)
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

        public static int[] convert_to_bin_int(int a)
        {
            //            int[] x = new int[0];
            int temp = a;
            int length = 0;
            for (int i = 0; temp > 0; i++)
            {
                length++;
                temp = temp / 2;
            }
            int[] x = new int[length];
            for (int i = 0; a > 0; i++)
            {
                x[i] = a % 2;
                a = a / 2;
            }
            return x;
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

        public static int[] First_int(int[] a, int la)
        {
            for (int i = 0; i < la; i++)
            {
                if (a[i] == 1)
                {
                    a[i] = 0;
                    break;
                }
                else if(a[i] == 0)
                {
                    a[i] = 1;
                }
            }
            return a;
        }

        //public static bool Second(string a, string b)
        //{
        //    bool ToReturn = true;
        //    if (a.Length != b.Length)
        //    {
        //        string ToExtend = "";
        //        for (int i = 0; i < (Math.Abs((a.Length) - (b.Length))); i++)
        //        {
        //            ToExtend += "0";
        //        }
        //        if ((a.Length) < (b.Length))
        //        {
        //            ToExtend += a;
        //            a = ToExtend;
        //        }
        //        else
        //        {
        //            ToExtend += b;
        //            b = ToExtend;
        //        }
        //    }
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] != b[i])
        //        {
        //            ToReturn = false;
        //            break;
        //        }
        //    }
        //    return (ToReturn);
        //}

        public static bool Second(int a, int b, int la, int lb)
        {
            bool ToReturn = false;
            if (la!=lb)
                return ToReturn;
            else
            {
                ToReturn = true;
                for (int i = 0; i<la; i++)
                {
                    int check1 = a % (Convert.ToInt32(Math.Pow(10, i+1)));
                    check1 = check1 / (Convert.ToInt32(Math.Pow(10, i)));
                    int check2 = b % (Convert.ToInt32(Math.Pow(10, i+1)));
                    check2 = check2 / (Convert.ToInt32(Math.Pow(10, i)));
                    if (check1 != check2)
                    {
                        ToReturn = false;
                        break;
                    }
                }
                return ToReturn;
            }
            //int x = 0, y = 0;
            //bool output = true;
            //for (int i = 0; i < la; i++)
            //{
            //    x += a[i] * Convert.ToInt32(Math.Pow(10, la - i));
            //}
            //for (int i = 0; i < lb; i++)
            //{
            //    y += b[i] * Convert.ToInt32(Math.Pow(10, lb - i));
            //}
            //int dif = Math.Abs(la - lb);
            //if (la != lb)
            //{
            //    output = false;
            //}
            //else
            //{
            //    for (int i = 0; i < (la); i++)
            //    {
            //        if ((x % Convert.ToInt32(Math.Pow(10, la - i))) / Math.Pow(10, i) != (y % Convert.ToInt32(Math.Pow(10, lb - i))) / Math.Pow(10, i))
            //        {
            //            output = false;
            //            break;
            //        }
            //    }
            //}
            //return (output);
        }
    }
}
