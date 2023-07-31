using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator(+,*,/,-): ");
            string opt = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (opt == "+")
            {
                Console.WriteLine("Summation is: " + (num1 + num2));
            }
            else if (opt == "-")
            {
                Console.WriteLine("Substraction is: " + (num1 - num2));
            }
            else if (opt == "*")
            {
                Console.WriteLine("Multipication is: " + (num1 * num2));
            }
            else if (opt == "/")
            {
                Console.WriteLine("Division is: " + (num1 / num2));
            }
        }
    }
}
