using AbstractFactory2.AbstractAnimals;
using AbstractFactory2.ArcticAnimals;
using AbstractFactory2.ForestAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.Factories
{
    public class ForestFactory : IFactory
    {
        private Random rnd = new Random();

        public string Habitat = "forest";
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
            BrownBear bear = new BrownBear();

            this.SetState(bear);

            bear.Habitat = Habitat;

            return bear;

        }

        public AbstractBird CreateBird()
        {
            Owl bird = new Owl();

            this.SetState(bird);

            bird.Habitat = Habitat;

            return bird;
        }

        public AbstractCat CreateCat()
        {
            Ocelot cat = new Ocelot();

            this.SetState(cat);

            cat.Habitat = Habitat;

            return cat;
        }

        public AbstractFish CreateFish()
        {
            Salmon fish = new Salmon();

            this.SetState(fish);

            fish.Habitat = Habitat;

            return fish;
        }
    }
}
