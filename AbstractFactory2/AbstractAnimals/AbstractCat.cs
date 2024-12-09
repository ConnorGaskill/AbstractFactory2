using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.AbstractAnimals
{
    public abstract class AbstractCat : AbstractAnimal
    {

        public AbstractCat()
        {
            this.Type = "cat";
            this.Diet = "carnivore";
        }
        public void Stretch()
        {

            Console.WriteLine($"The {this.Name} is stretching.");

            return;

        }


    }
}
