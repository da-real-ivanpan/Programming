using System;

namespace Lab_Rob_5_Var_2_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Base FirstClass = new Base("Sample text is always fun!");
            Heritage SecondClass = new Heritage("Text from Base is always fun!", 123456789, "Text from Heritage is very different");
            Console.WriteLine("Original input: ");
            SecondClass.Info();
            Console.WriteLine("Length of Text: " + SecondClass.GetLength());
            SecondClass.InvertText();
            SecondClass.InvertNumber();
            Console.WriteLine("New output: ");
            SecondClass.Info();
            Console.WriteLine("Length of Text: " + SecondClass.GetLength());
        }
    }
}
