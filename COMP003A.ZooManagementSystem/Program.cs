﻿// Author: Jean Bryant Figueroa
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

            
            int choice = 0;
            while (choice != 5)
            {
                Console.Write("Please choose an option:\r\n1. Add a Lion\r\n2. Add a Parrot\r\n3. Display All Animals\r\n4. Describe an Animal\r\n5. Exit\r\n");
                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                        {
                            break;
                        }
                        case 2:
                        {
                            break;
                        }
                        case 3:
                        {
                            break;
                        }
                        case 4:
                        {
                                break;
                        }
                    }
                }
                catch { }
            }
        }
    }
}