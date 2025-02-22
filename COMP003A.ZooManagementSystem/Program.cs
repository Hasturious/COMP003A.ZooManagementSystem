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
            //Our aniaml list
            List<Animal> animals = new List<Animal>();
            
            //If the user does any option that isnt 5 the loop continues
            string choice = "0";
            while (choice != "5")
            {
                Console.Write("Please choose an option:\r\n1. Add a Lion\r\n2. Add a Parrot\r\n3. Display All Animals\r\n4. Describe an Animal\r\n5. Exit\r\n");
                choice = Console.ReadLine();

                try
                {
                    //If the user tries any option that isnt between 1 and 5 we let them know its not valid
                    if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                        throw new ArgumentException("Invalid input. Only numbers 1-5 are allowed.");
                    switch (choice)
                    {
                        case "1":
                        {
                            try
                            {
                                //Let the user name the lion which ofcourse cant be null so I used a simple isNullOrWhiteSpace
                                Console.Write("Enter the name of the lion: ");
                                string name = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(name))
                                {
                                    throw new ArgumentException("Name cannot be null or empty.");
                                }

                                //Same here with the name
                                Console.Write("Enter the species of the lion: ");
                                string species = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(species))
                                {
                                      throw new ArgumentException("Species cannot be null or empty.");
                                }
                                Console.WriteLine();

                                //Add the new lion to the Lion class
                                Animal lion = new Lion(name, species);
                                //add lion to the list of animals
                                animals.Add(lion);

                                Console.WriteLine("Lion added successfully!");
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
                                
                                Console.Write("Enter the name of the parrot: ");
                                string name = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(name))
                                {
                                    throw new ArgumentException("Name cannot be null or empty.");
                                }

                                Console.Write("Enter the species of the parrot: ");
                                string species = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(species))
                                {
                                    throw new ArgumentException("Species cannot be null or empty.");
                                }
                                Console.WriteLine();

                                Animal parrot = new Parrot(name, species);
                                animals.Add(parrot);

                                Console.WriteLine("parrot added successfully!");
                                }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;
                            }
                        case "3":
                        {
                            Console.WriteLine("Displaying all animals:");
                            ZooUtility.DisplayAllAnimals(animals);
                            break;
                        }
                        case "4":
                        {
                            ZooUtility describeAnimal = new ZooUtility();

                            Console.Write("Enter the name of the animal to describe: ");
                            string name = Console.ReadLine();
                            describeAnimal.DescribeAnimal(name);

                            Console.Write("\nEnter the species of the animal: ");
                            string species = Console.ReadLine();
                            describeAnimal.DescribeAnimal(name, species);

                            Console.Write("\nEnter the age of the animal: ");
                            string ageInput = (Console.ReadLine());

                            int age = -1; //Obviously the age of the animal cant be negative anything so we can use -1 as our way to dectect if no age was input

                            if (!string.IsNullOrEmpty(ageInput)) 
                            {
                                age = int.Parse(ageInput);//If there was an input we can turn the string number into an int
                                describeAnimal.DescribeAnimal(name, species, age);
                            }
                            /*
                            else
                            {
                                describeAnimal.DescribeAnimal(name, species, age);
                                //Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old");
                            }
                            */

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