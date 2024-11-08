using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalSounds
{
    internal class AnimalFactory
    {
        public static Animals CreateAnimal(enmAnimals animal, string name)
        {
            switch (animal)
            {
                case enmAnimals.Dog:
                    return new Dog(name);
                case enmAnimals.Cat:
                    return new Cat(name);
                case enmAnimals.Sheep:
                    return new Sheep(name);
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }

        public static Animals CreateAnimal(enmAnimals animal)
        {
            switch (animal)
            {
                case enmAnimals.Dog:
                    return new Dog("Bella");
                case enmAnimals.Cat:
                    return new Cat("Luna");
                case enmAnimals.Sheep:
                    return new Sheep("Dolly");
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
