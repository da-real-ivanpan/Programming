using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_5_Var_2_Panasenko
{
    public class Base
    {
        public string Text;

//        Base ()
//        {
//            Text = "Sample text, Darling";
//       }

        public Base (string a)
        {
            Text = a;
        }

        public int GetLength()
        {
            return Text.Length;
        }
    }

}
