using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05ques06
{
    internal class ArrayInputs
    {
        private int[] array;

        public ArrayInputs(int[] array)
        {
            this.array = array;
        }

        public void GetUserInput()
        {
             
            for (int i = 0; i < array.Length; i++)
            {
                 
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
                array[i + 1] = 0;
            }
        }
    }
}
