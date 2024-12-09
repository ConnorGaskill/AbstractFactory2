using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2.JungleAnimals
{
    internal class Tiger : AbstractCat
    {
        public Tiger()
        {
            this.Name = "tiger";
        }
    }
}
