using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.ForestAnimals
{
    internal class Cougar : AbstractCat
    {
        public Cougar()
        {
            this.Name = "cougar";
        }
    }
}
