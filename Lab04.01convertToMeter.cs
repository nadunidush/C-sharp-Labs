using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._01
{
    internal class convertToMeter
    {
        public void KilometerToMeter(double km)
        {
            // Convert km to m
            double m = km * 1000;

            // Display the result
            Console.WriteLine($"{km} km = {m} m");
        }
    }
}
