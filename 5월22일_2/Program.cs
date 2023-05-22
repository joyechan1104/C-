using ConsoleApp1;


internal class Program
{
    private static void Main(string[] args)
    {
        List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
        List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

        foreach (var item in Dogs)
        {
            item.Eat();
            item.sleep();
            item.Bark();
        }

        foreach (var item in Cats)
        {
            item.Eat();
            item.sleep();
            item.Meow();
        }

        Point p = new Point();
        p.set(1, 2);
        p.showPoint();

        ColorPoint cp = new ColorPoint();
        cp.set(3, 4);
        cp.setColor("red");
        cp.showColorPoint();
    }
}