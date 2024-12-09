using AbstractFactory2.ArcticAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.AbstractAnimals;
namespace AbstractFactory2.Factories
{
    public class ArcticFactory : IFactory
    {

        private Random rnd = new Random();

        public string Habitat = "forest";

        public AbstractAnimal CreateRandomAnimal()
        {
            int num = rnd.Next(1,5);

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
            PolarBear bear = new PolarBear();

            this.SetState(bear);

            bear.Habitat = this.Habitat;

            return bear;

        }

        public AbstractBird CreateBird()
        {
            Puffin bird = new Puffin();

            this.SetState(bird);

            bird.Habitat = this.Habitat;

            return bird;
        }

        public AbstractCat CreateCat()
        {
            Lynx cat = new Lynx();

            this.SetState(cat);

            cat.Habitat = this.Habitat;

            return cat;
        }

        public AbstractFish CreateFish()
        {
            Shark fish = new Shark();

            this.SetState (fish);

            fish.Habitat = this.Habitat;

            return fish;
        }
    }
}
