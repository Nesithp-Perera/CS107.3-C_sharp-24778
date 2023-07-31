using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.PrintAnimal();

            Dog dog = new Dog();
            dog.PrintAnimal();
            dog.PrintDog();
            Console.ReadKey();
            
        }
    }
    
}
