using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.AbstractAnimals
{
    public abstract class AbstractBird : AbstractAnimal
    {

        public AbstractBird()
        {
            this.Type = "bird";
        }
        public void Preen()
        {

            Console.WriteLine($"The {this.Name} is preening it's feathers");

            return;

        }


    }
}
