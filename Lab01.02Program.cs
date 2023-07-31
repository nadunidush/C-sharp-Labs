using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius for calculate area of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle is: " + area);
            
        }
    }
}
