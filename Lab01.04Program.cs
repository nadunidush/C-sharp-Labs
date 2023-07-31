using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary Calculator!");

            
            Console.Write("Enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

             
            Console.Write("Enter the tax rate (in percentage): ");
            double taxRate = Convert.ToDouble(Console.ReadLine());
            

             
            double taxAmount = (salary * taxRate) / 100;
            double netSalary = salary - taxAmount;

            
            Console.WriteLine($"Employee's Salary: ${salary}");
            Console.WriteLine($"Tax Rate: {taxRate}%");
            Console.WriteLine($"Net Salary after Tax: ${netSalary}");
            Console.ReadKey();
        }
    }
}
