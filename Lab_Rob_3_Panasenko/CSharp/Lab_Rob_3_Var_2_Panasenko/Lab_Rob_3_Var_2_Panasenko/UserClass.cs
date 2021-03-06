﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_3_Var_2_Panasenko
{
    class Massive
    {
        public char[] elements = new char[10] { 'a', 'b', 'c', 'd', 'E', 'F', 'g', 'h', 'i', 'j' };

        private int Ammount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    if ("eyuioaEYUIOA".Contains(elements[i]))
                        count++;
                }
                return count;
            }
        }

        public string GetElement
        {
            get
            {
                Console.Write("Which element do you want to see? ");
                int element = Convert.ToInt32(Console.ReadLine());
                if (element > elements.Length - 1)
                    return "Index out of range!";
                else if (elements[element-1] != char.ToUpper(elements[element-1]))
                    return "Not upper character!";
                else
                    return Convert.ToString(elements[element-1]);
            }
        }

        public int ShowAndTell()
        {

                Console.Write("Elements of array: ");
                for (int i = 0; i < elements.Length; i++)
                {
                Console.Write(elements[i] + ", ");
            }
            return 0;
        }

        public int GetAmmount
        { 
            get 
            { 
                return Ammount; 
            } 
        }

        public char this[int index]
        {
            get
            {
                return elements[index];
            }
            set
            {
                elements[index] = value;
            }
        }
    }
}