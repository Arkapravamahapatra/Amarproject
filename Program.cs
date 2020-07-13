using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amarproject
{
    class Program
    {
        static void Main(string[] args)
        {
			int num1, num2, Add, minus, multiply, divide;
			Console.WriteLine("Enter the First Number and Second Number");
			num1 = Convert.ToInt16(Console.ReadLine());
			num2 = Convert.ToInt16(Console.ReadLine());
			Add = num1 + num2;
			Console.WriteLine(Add);
			minus = num1 - num2;
			Console.WriteLine(minus);
			multiply = num1 * num2;
			Console.WriteLine(multiply);
			divide = num1 / num2;
			Console.WriteLine(divide);
		}
	}
}
