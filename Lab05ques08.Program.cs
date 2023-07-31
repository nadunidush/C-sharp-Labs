using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05ques08
{
    internal class Program
    {
        class Animal
        {
            public void IAmAnimal()
            {
                Console.WriteLine("I am an animal");
            }
        }
            class Dog : Animal
        {
            public void IHaveFourLegs()
            {
                Console.WriteLine("I have four legs");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.IAmAnimal();
            dog.IHaveFourLegs();
        }

         

         
    }
}
