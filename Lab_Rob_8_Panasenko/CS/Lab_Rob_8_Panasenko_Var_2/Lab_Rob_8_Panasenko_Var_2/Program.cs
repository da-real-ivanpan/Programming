using System;

public delegate string MyDelegate(int x);

namespace Lab_Rob_8_Panasenko_Var_2
{
    class Program
    {

//        static int changeCount;
//        static void ListChanged(object sender, EventArgs e)
//        {
//            changeCount++;
//        }


        static void Main(string[] args)
        {
            int x, y;
            string Text;
            char Element;
            //указатель
            //int(*fcnPtr)(string a, char b) = CountElement; // fcnPtr указывает на функцию boo
            //fcnPtr = CountElement; // fcnPt
            Console.Write("Please enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter y: ");
            y = Convert.ToInt32(Console.ReadLine());
            MathOp XandY = new MathOp(x, y);
            XandY.DivHappened += XandY.Message;

            XandY.info();

            Console.Write("Enter text: ");
            Text = Console.ReadLine();
            Console.Write("Please enter element: ");
            Element = Convert.ToChar(Console.ReadLine());

//            MyDelegate d1 = new MyDelegate(Program.CountElement);

            Console.WriteLine("Ammount of element in text: " + CountElement(Text, Element));
            //Console.WriteLine("Ammount of element in text (example method): " + CountElement(Text, Element));
        }
        static int CountElement(string text, char a)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == a)
                    count++;
            }
            return count;
        }
    }
}
