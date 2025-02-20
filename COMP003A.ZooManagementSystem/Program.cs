// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            
            string choice = "0";
            while (choice != "5")
            {
                Console.Write("Please choose an option:\r\n1. Add a Lion\r\n2. Add a Parrot\r\n3. Display All Animals\r\n4. Describe an Animal\r\n5. Exit\r\n");
                choice = Console.ReadLine();

                try
                {
                    if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5")
                        throw new ArgumentException("Invalid input. Only numbers 1-5 are allowed.");
                    switch (choice)
                    {
                        case "1":
                        {
                            try
                            {
                                Console.Write("Enter the name of the lion: ");
                                string name = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(name))
                                    throw new ArgumentException("Name cannot be null or empty.");

                                Console.Write("Enter the species of the lion: ");
                                string species = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(species))
                                      throw new ArgumentException("Species cannot be null or empty.");
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;
                        }
                        case "2":
                        {
                            try
                            {
                                //nullorwhitespace prevents either nothing or spaces from being the value from these inputs
                                Console.Write("Enter the name of the lion: ");
                                string name = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(name))
                                    throw new ArgumentException("Name cannot be null or empty.");

                                Console.Write("Enter the species of the lion: ");
                                string species = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(species))
                                    throw new ArgumentException("Species cannot be null or empty.");
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;
                        }
                        case "3":
                        {
                            break;
                        }
                        case "4":
                        {
                            break;
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}