using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.ForestAnimals
{
    internal class Owl : AbstractBird
    {
        public Owl()
        {
            this.Diet = "carnivore";
            this.Name = "owl";
        }
    }
}
