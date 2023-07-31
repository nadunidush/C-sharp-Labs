using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04que02
{
    internal class FindValues
    {
        private double radius;

        public FindValues(double radius)
        {
            this.radius = radius;
        }

        public double FindArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public double FindCircumference()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
