using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Rob_8_Panasenko_Var_2
{
    class MathOp
    {
		public int x, y, sum, dif, mult, divide, whatleft;
		public delegate void Divided();
		public event Divided DivHappened;

		public MathOp(int a, int b)
		{
			x = a;
			y = b;
			sum = a + b;
			dif = Math.Abs(a - b);
			mult = a * b;
			divide = a / b;
			whatleft = a % b;
		}

		public void info()
		{
			DivHappened();
			Console.WriteLine("Operations with numbers:");
			Console.WriteLine (x + " + " + y + " = " + sum);
			Console.WriteLine("| " + x + " - " + y + " | = " + dif);
			Console.WriteLine(x + " * " + y + " = " + mult);
			Console.WriteLine(x + " / " + y + " = " + divide);
			Console.WriteLine(x + " % " + y + " = " + whatleft);
		}

		public void Message()
		{
			Console.WriteLine("Division happened!");
		}

	}
}
