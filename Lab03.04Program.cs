using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Enter an upper limit: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            
            int sum = 0;

            
            for (int i = 1; i <= upperLimit; i += 2)
            {
                sum += i;
            }

             
            Console.WriteLine("The sum of the odd numbers is: {0}", sum);
        }
    }
}
