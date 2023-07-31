using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05ques06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size: ");
            int arraySize = int.Parse(Console.ReadLine());
             
            int[] array = new int[arraySize];
             
            ArrayInputs input = new ArrayInputs(array);
             
            input.GetUserInput();
             
            Console.WriteLine("The array contents are:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
