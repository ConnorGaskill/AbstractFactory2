using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.ForestAnimals
{
    internal class BrownBear : AbstractBear
    {
        public BrownBear()
        {
            this.Name = "brown bear";
        }
    }
}
