using ConsoleApp1;


internal class Program
{
    private static void Main(string[] args)
    {
        //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
        //List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
        List<Animal> Animals = new List<Animal>()
        {
            new Dog(), new Cat(), new Cat(), new Dog(),
        };

        foreach (var item in Animals)
        {
            item.Eat();
            item.sleep();

            if (item is Dog) { ((Dog)item).Bark(); }
            if (item is Cat) { ((Cat)item).Meow(); }
        }
    }
}