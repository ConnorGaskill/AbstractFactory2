using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2
{
    public interface IFactory
    {
        AbstractAnimal CreateRandomAnimal();
        AbstractBear CreateBear();

        AbstractBird CreateBird();

        AbstractCat CreateCat();

        AbstractFish CreateFish();


    }
}
