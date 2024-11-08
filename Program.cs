namespace AnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Spike");
            Console.WriteLine(dog.MakeSound());
            Animals cat = AnimalFactory.CreateAnimal(enmAnimals.Cat, "Tom");
            Console.WriteLine(cat.MakeSound());
            Animals sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep, "Tim");
            Console.WriteLine(sheep.MakeSound());
        }
    }
}
