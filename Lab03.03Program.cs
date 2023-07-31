using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

             
            int sum = 0;

             
            for (int i = 0; number > 0; i++)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }

             
            Console.WriteLine("The sum of the digits is: {0}", sum);
        }
    }
}
