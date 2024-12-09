using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.AbstractAnimals
{
    public abstract class AbstractAnimal
    {
        public string Name {  get; set; }

        public string Type {  get; set; }

        public string Diet {  get; set; }

        public string State { get; set; }

        public string Habitat {  get; set; }


    }
}
