using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04que02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues findValues = new FindValues(radius);

            double area = findValues.FindArea();
            double circumference = findValues.FindCircumference();

            Console.WriteLine("The area of the circle is {0}", area);
            Console.WriteLine("The circumference of the circle is {0}", circumference);
        }
    }
}
