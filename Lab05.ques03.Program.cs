using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05ques03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());

            Calculator calculateValues = new Calculator();

            double addition = calculateValues.Addition(num1, num2);
            double subtraction = calculateValues.Subtraction(num1, num2);
            double multiplication = calculateValues.Multiplication(num1, num2);
            double division = calculateValues.Division(num1, num2);

            Console.WriteLine("Addition: {0}", addition);
            Console.WriteLine("Subtraction: {0}", subtraction);
            Console.WriteLine("Multiplication: {0}", multiplication);
            Console.WriteLine("Division: {0}", division);
        }
    }
}
