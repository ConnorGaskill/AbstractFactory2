using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.MountainAnimals
{
    internal class Eagle : AbstractBird
    {
        public Eagle()
        {
            this.Diet = "carnivore";
            this.Name = "eagle";
        }
    }
}
