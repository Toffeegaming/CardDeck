namespace Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field1 = new Field(0);
            field1.AddAnimal(new Goat(4, 0));
            field1.AddAnimal(new Sheep(7, 0));
            field1.ShowAnimals();

            Field field2 = new Field(1);
            field2.AddAnimal(new Sheep(3, 0));
            field2.AddAnimal(new Goat(2, 0));
            field2.ShowAnimals();

            field1.FeedAnimals("hay");
            field1.FeedAnimals("hay");
            field1.FeedAnimals("carrot");
            field1.FeedAnimals("hay");
            field1.PetAnimals();

            field2.FeedAnimals("hay");
            field2.FeedAnimals("carrot");
            field2.PetAnimals();
            field2.PetAnimals();
            field2.PetAnimals();
            field2.PetAnimals();
            field2.PetAnimals();
            field2.PetAnimals();
        }
    }
}