using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter An Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter Another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Please enter an operator");
            }

            Console.ReadLine();
        }

    }
}
