using System;

namespace Lab_Rob_2_V_2_Panasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write text: ");
            string text = Console.ReadLine();
            uContainer uC = new uContainer();
            int choose = -1;
            while (choose != 0)
            {
                Console.WriteLine("Choose futher procedures with text: ");
                Console.WriteLine("1 - add line to text;");
                Console.WriteLine("2 - remove line from text;");
                Console.WriteLine("3 - remove multiple lines from text;");
                Console.WriteLine("4 - remove elements from text in specific range;");
                Console.WriteLine("5 - output the length of the longest line;");
                Console.WriteLine("6 - make every word in the text start with high register;");
                Console.WriteLine("0 - exit programme.");
                Console.Write("Input action: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case (1):
                        string b = "";
                        Console.Write("Enter second text: ");
                        b = Console.ReadLine();
                        text = uC.CAddLine(text, b);
                        Console.WriteLine("Result: " + text);
                        break;
                    case (2):
                        Console.Write("Enter second text: ");
                        string b2 = Console.ReadLine();
                        text = uC.CRemoveLine(text, b2);
                        Console.WriteLine("Result: " + text);
                        break;
                    case (3):
                        Console.Write("Enter second text: ");
                        string b3 = Console.ReadLine();
                        text = uC.CRemoveLines(text, b3);
                        Console.WriteLine("Result: " + text);
                        break;
                    case (4):
                        int start, stop;
                        Console.Write("Enter start element: "); 
                        start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter final element: ");
                        stop = Convert.ToInt32(Console.ReadLine());
                        text = uC.ClearText(text, start, stop);
                        Console.WriteLine("Result: " + text);
                        break;
                    case (5):
                        Console.WriteLine("Length of the longest line: " + uC.LongestLine(text));
                        break;
                    case (6):
                        text = uC.CHigh(text);
                        Console.WriteLine("Result: " + text);
                        break;
                    case (0):
                        break;
                }
            }
        }
    }

    class uString
    {
        public string[] uSplit(string a, char b)
        {

            string[] splittedStrings = a.Split(b);
            return splittedStrings;
        }

        public string RemoveElements(string[] a, int[] n)
        {
            string b = "";
            for (int i = 0; i<a.Length; i++)
            {
                int check = 1;
                for (int j = 0; j<n.Length; j++)
                    if (n[j]==i)
                    {
                        check = 0;
                        break;
                    }
                if (check == 1)
                    if (a[i]!="")
                        b += a[i] + '.';
            }
            return b;
        }
    }

    class uContainer
    {
        public string CAddLine (string a, string b)
        {
            a += b;
            return a;
        }

        public string CRemoveLine(string a, string b)
        {
            for (int i = 0; i < a.Length - (b.Length-1); i++)
            {
                int check = 1;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i + j] != b[j])
                    {
                        check = 0;
                        break;
                    }
                }
                if (check != 0)
                {
                    a = a.Remove(i, b.Length);
                    break;
                }
            }
            return a;

        }

        public string CRemoveLines(string a, string b)
        {
            uString uS = new uString();
            string[] splitted = uS.uSplit(a, '.');
            int checkfinal = 0;
            if (splitted[splitted.Length - 1] == "")
                checkfinal = 1;
            for (int i = 0; i < splitted.Length - checkfinal; i++)
                if (splitted[i][0] == ' ')
                    splitted[i].Remove(0);
            int MasLength = 0;
            for (int i = 0; i < splitted.Length-checkfinal; i++)
            {
                if (splitted[i] == b || splitted[i] == " " + b)
                {
                    MasLength += 1;
                }
            }
            int count = 0;
            int[] ToDelete = new int[MasLength];
            for (int i = 0; i < splitted.Length; i++)
            {
                if (splitted[i] == b || splitted[i] == " " + b)
                {
                    ToDelete[count] = i;
                    count++;
                }
            }
            string ToReturn = uS.RemoveElements(splitted, ToDelete);
            return ToReturn;
        }
    

        public string ClearText(string a, int start, int end)
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i > end - 1 || i < start - 1)
                    b += a[i];
            }
            return b;
        }

        public int LongestLine(string a)
        {
            uString uS = new uString();
            string[] splitted = uS.uSplit(a, '.');
            int longest = 0;
            for (int i = 0; i < splitted.Length; i++)
            {
                int ALength = 0;
                for (int j = 0; j < splitted[i].Length; j++)
                {
                    if (splitted[i][j] == ' ' && j == 0)
                    {

                    }
                    else
                    {
                        ALength++;
                    }
                }
                if (longest < ALength)
                    longest = ALength;
            }
            return longest;
        }

        public string CHigh(string a)
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0 || (a[i - 1] == ' '))
                {
                    b += char.ToUpper(a[i]);
                }
                else
                {
                    b += a[i];
                }
            }
            return b;
        }
    }
}
