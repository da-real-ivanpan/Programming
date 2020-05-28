using System;
using System.Collections;

namespace Lab_Rob_7_Var_2_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenos Dias");
            CustomStack<float> Boi = new CustomStack<float>();
            Console.Write("Do you want to write everything by hand? y/n: ");
            char Answer = Convert.ToChar(Console.ReadLine());
            if (Answer != 'y')
            {
                Boi.Push(new linkedNode<float>(float.Parse("3,6")));
                Boi.Push(new linkedNode<float>(float.Parse("10,0")));
                Boi.Push(new linkedNode<float>(float.Parse("2,3")));
                Boi.Push(new linkedNode<float>(float.Parse("5,5")));
                Boi.Push(new linkedNode<float>(float.Parse("7,1")));
                Boi.Push(new linkedNode<float>(float.Parse("1,6")));
                Boi.Push(new linkedNode<float>(float.Parse("12,8")));
                Boi.Push(new linkedNode<float>(float.Parse("9,9")));
                Boi.Push(new linkedNode<float>(float.Parse("15,0")));
                Boi.Push(new linkedNode<float>(float.Parse("17,6")));
            }
            else
            {
                string temp1 = Console.ReadLine();
                while (temp1 != "")
                {
                    float temp = float.Parse(temp1);
                    Boi.Push(new linkedNode<float>(temp));
                    temp1 = Console.ReadLine();
                }
            }
            Console.WriteLine("Bois in stack: ");
            Boi.Traverse();
            int count = 0;
            CustomStack<float> tempST = Boi;
            CustomStack<float> NewBoi = new CustomStack<float>();
            //while (tempST.head != null || tempST.tail != null)
            while (tempST.head != null)
            {
            //    if(tempST.head == null)
            //    {
            //        Console.WriteLine(tempST.tail.Data);
            //        NewBoi.Push(new linkedNode<float>(tempST.tail.Data));
            //        if (tempST.tail.Data > 10.5)
            //            count++;
            //        break;
            //    }
                linkedNode<float> tempF = tempST.Peek();
                NewBoi.Push(new linkedNode<float>(tempF.Data));
                tempST.Pop();
                if (tempF.Data > 10.5)
                    count++;
            }
            Boi = NewBoi;
            Console.Write("Perfect Bois that are higher than 10.5: ");
            Console.WriteLine(count);
            int check = 0;
            Console.WriteLine("Deleting bad Bois");

            tempST = Boi;
            NewBoi = new CustomStack<float>();

            //while (tempST.head != null || tempST.tail != null)
            while (tempST.head != null)
            {
                //if (tempST.head == null)
                //{
                 //   Console.WriteLine(tempST.tail.Data);
                //    if (tempST.tail.Data >= 2.6)
                //        NewBoi.Push(new linkedNode<float>(tempST.tail.Data));
                //    break;
                //}
                linkedNode<float> tempF = tempST.Pop();
                //tempST.Pop();
                if (tempF.Data >= 2.6)
                    NewBoi.Push(new linkedNode<float>(tempF.Data));
            }
            Boi = NewBoi;

            Console.WriteLine("Bad Bois removed. Good Bois are:");
            Boi.Traverse();
//            tempST = Boi;
//            while (tempST.head != null ||  tempST.tail != null)
//            {
//                if (tempST.head == null)
//                {
//                    Console.WriteLine(tempST.tail.Data);
//                    break;
//                }
//                linkedNode<float> tempF = tempST.Peek();
//                tempST.Pop();
//            }
        }

        //Needed to delete elements from the middle, because Pop only removes element from the top
        static Stack PopEl(Stack a, float b)
        {
            Stack data = new Stack();
            foreach (float element in a)
            {
                data.Push(element);
                if (element == b)
                    data.Pop();
//                if (element != b)
//                    data.Push(element);
            }
            return data;
        }
    }
}
