using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    static class ZooUtility
    {
        public static void DisplayAllAnimals(List<Animal> animals)
        {
            Console.WriteLine("\nList of all animals:");
            foreach (var Animal in animals)
            {
                Animal.MakeSound();
                Console.Write($" {Animal.Name} {Animal.Species} ");
                
            }
            Console.WriteLine(); // Ensure the output is formatted correctly
        }
    }
}

