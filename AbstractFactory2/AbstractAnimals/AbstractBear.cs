using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.AbstractAnimals
{
    public abstract class AbstractBear : AbstractAnimal
    {

        public AbstractBear()
        {
            this.Type = "bear";
            this.Diet = "omnivore";
        }

        public void Hibernate()
        {
            Console.WriteLine($"The {this.Name} is sleeping");

            return;

        }


    }
}
