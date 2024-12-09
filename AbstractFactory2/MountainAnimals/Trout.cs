using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.MountainAnimals
{
    internal class Trout : AbstractFish
    {
        public Trout()
        {
            this.Name = "trout";
        }
    }
}
