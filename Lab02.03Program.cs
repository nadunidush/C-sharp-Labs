using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter the radius of the circle: ");
            int radius = int.Parse(Console.ReadLine());

             
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            
            Console.WriteLine("The area of the circle is: "+ area);
            Console.WriteLine("The circumference of the circle is: "+ circumference);
        }
    }
}
