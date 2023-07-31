using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._02
{
    internal class ConvertToMeter
    {
        public void KilometerToMeter(double km)
        {
             
            double m = km * 1000;
            Console.WriteLine("{0} km = {1} m", km, m);
        }
    }
}
