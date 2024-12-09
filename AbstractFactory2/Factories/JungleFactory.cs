using AbstractFactory2.AbstractAnimals;
using AbstractFactory2.ArcticAnimals;
using AbstractFactory2.JungleAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.Factories
{
    public class JungleFactory : IFactory
    {

        public string Habitat = "Jungle";

        private Random rnd = new Random();
        public AbstractAnimal CreateRandomAnimal()
        {
            int num = rnd.Next(1, 4);

            switch (num)
            {
                case 1:
                    return this.CreateBear();
                case 2:
                    return this.CreateFish();
                case 3:
                    return this.CreateCat();
                default:
                    return this.CreateBird();
            }
        }

        private void SetState(AbstractAnimal animal)
        {

            if (rnd.Next() % 2 == 0)
            {
                animal.State = "hungry";
            }
            else if (rnd.Next() % 3 == 0)
            {
                animal.State = "mad";
            }
            else
            {
                animal.State = "fed";
            }

        }

        public AbstractBear CreateBear()
        {
            Panda bear = new Panda();
            this.SetState(bear);
            bear.Habitat = Habitat;

            return bear;

        }

        public AbstractBird CreateBird()
        {
            Quetzal bird = new Quetzal();

            this.SetState(bird);
            bird.Habitat = Habitat;

            return bird;
        }

        public AbstractCat CreateCat()
        {
            Tiger cat = new Tiger();

            this.SetState(cat);
            cat.Habitat = Habitat;

            return cat;
        }

        public AbstractFish CreateFish()
        {
            Arapaima fish = new Arapaima();

            this.SetState(fish);
            fish.Habitat = Habitat;

            return fish;
        }
    }
}
