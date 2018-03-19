using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int answer;
            string oper;

            Console.WriteLine("Calculator!");

            Console.WriteLine("Enter your first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter your operator (x + - /): ");
            oper = Console.ReadLine();

            if (oper == "x")
            {
                answer = num1 * num2;
                Console.WriteLine(num1 + " x " + num2 + " = " + answer);
                Console.ReadLine();
            }

            else if (oper == "-")
            {
                answer = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + answer);
                Console.ReadLine();
            }

            else if (oper == "/")
            {
                answer = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + answer);
                Console.ReadLine();
            }

            else if (oper == "+")
            {
                answer = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + answer);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Could not understand the operator");
                Console.ReadLine();
            }
        }
    }
}
