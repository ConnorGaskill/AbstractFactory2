using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.MountainAnimals
{
    internal class BlackBear : AbstractBear
    {
        public BlackBear()
        {
            this.Name = "black bear";
        }
    }
}
