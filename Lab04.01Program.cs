using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            convertToMeter convertvalue = new convertToMeter();
            Console.WriteLine("Enter the Kilometer value: ");
            double km = Convert.ToDouble(Console.ReadLine());
            convertvalue.KilometerToMeter(km);
        }
    }
}
