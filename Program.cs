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
            //Global Variables
            List<int> numbers = new List<int>();
            List<string> operators = new List<string>();
            int num1;
            int num2;
            int answer;
            string oper;

            Console.WriteLine("Calculator!");

            //Getting all the user info

            while (operators != "=")
            {
                Console.WriteLine("Enter an integer: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Now enter an operator (x + - / =): ");
                oper = Console.ReadLine();
                operators.Add(oper);
            }
            //Running the math based on the operator
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
