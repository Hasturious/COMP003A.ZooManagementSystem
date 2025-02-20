using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class Animal
    {
        private string _name;
        private string _species;

        //Name/Species definers
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Species { get; set; }

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
    }
}
