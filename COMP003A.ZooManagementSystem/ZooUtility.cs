using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public class ZooUtility
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
        
        /// <summary>
        /// Constructs  and overloads the DescribeAnimal method
        /// </summary>
        /// <param name="name"></param>
        public void DescribeAnimal(string name)
        {
            Console.WriteLine($"Animal Name: {name}");
        }

        /// <summary>
        /// Constructs  and overloads the DescribeAnimal method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public void DescribeAnimal(string name, string species)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}");
        }

        /// <summary>
        /// Constructs  and overloads the DescribeAnimal method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        /// <param name="age"></param>
        public void DescribeAnimal(string name, string species, int age)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years");
        }
        

    }
}

