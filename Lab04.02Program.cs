using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConvertToMeter convertValues = new ConvertToMeter();

             
            Console.WriteLine("Enter the kilometer value: ");
            double km = double.Parse(Console.ReadLine());

             
            convertValues.KilometerToMeter(km);
        }
    }
}
