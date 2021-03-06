﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_7_Var_2_Panasenko
{
    public class linkedNode<T>
    {
        public linkedNode<T> next;
        public T Data;
        public linkedNode(T Data)
        {
            this.Data = Data;
        }
    }

    public class CustomStack<T>
    {
        public void Traverse()
        {
            linkedNode<T> cursor = head;
            while (cursor != null)
            {
                Console.WriteLine(cursor.Data);
                cursor = cursor.next;
            }
        }
        public linkedNode<T> head;
        public linkedNode<T> tail;

        // returns the head without removing it
        public linkedNode<T> Peek()
        {
            if (head == null)
                throw new Exception("the stack is empty");
            return head;
        }

        // returns the head and removes it
        public linkedNode<T> Pop()
        {
            if (head == null)
                throw new Exception("the stack is empty");

            linkedNode<T> node = new linkedNode<T>(head.Data);
            head = head.next;
            return node;
        }

        public void Push(linkedNode<T> node)
        {
            if (head != null)
                node.next = head;
            else
            {
                node.next = null;
                tail = node;
            }

            head = node;
        }
    }

}
