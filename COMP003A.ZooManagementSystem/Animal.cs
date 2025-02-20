using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    abstract class Animal
    {
        private string _name;
        private string _species;

        //Name/Species definers
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Name can't be empty");
                _name = value;
            }
        }
        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Species can't be null or empty.");
                _species = value;
            }
        }

        /// <summary>
        /// Animal constructor
        /// </summary>
        /// <param name="namem"></param>
        /// <param name="species"></param>
        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public abstract void MakeSound();
    }
}
