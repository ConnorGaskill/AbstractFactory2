using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.ArcticAnimals
{
    public class Puffin : AbstractAnimals.AbstractBird
    {
        public Puffin()
        {
            this.Name = "puffin";
            this.Diet = "carnivore";
        }
    }
}
