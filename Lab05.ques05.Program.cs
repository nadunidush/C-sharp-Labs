using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05ques05
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            int[] array = new int[10];
 
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter value: ");
                array[i] = int.Parse(Console.ReadLine());
            }
             
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
             
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
             
            int averageValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                averageValue += array[i];
            }
            averageValue /= array.Length;
             
            int[] reversedArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }
 
            Console.WriteLine("Minimum value: {0}", minValue);
            Console.WriteLine("Maximum value: {0}", maxValue);
            Console.WriteLine("Average value: {0}", averageValue);
            Console.WriteLine("Reversed array: {0}", reversedArray);
        }
    }
}
