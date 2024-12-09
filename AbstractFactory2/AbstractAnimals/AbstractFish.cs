using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.AbstractAnimals
{
    public abstract class AbstractFish : AbstractAnimal
    {

        public AbstractFish()
        {
            this.Type = "fish";
            this.Diet = "omnivore";
        }

        public void Swim()
        {

            Console.WriteLine($"The {this.Name} is swimming");

        }

    }
}
