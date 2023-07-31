using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputs = new int[10];

             
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the {0}th number: ", i + 1);
                userInputs[i] = int.Parse(Console.ReadLine());
            }

             
            for (int i = 0; i < 10; i++)
            {
                int number = userInputs[i];

                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} is even", number);
                }
                else
                {
                    Console.WriteLine("{0} is odd", number);
                }
            }
        }
    }
}
