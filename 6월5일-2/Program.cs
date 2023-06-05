﻿class Program /*425p~429p 인터페이스*/
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object? obj)
        {
            return this.Price.CompareTo((obj as Product).Price);
            /*throw new NotImplementedException();*/
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }

    static void Main(string[] args)
    {
        List<Product> list = new List<Product>()
        {
            new Product() { Name = "고구마", Price = 1500 },
            new Product() { Name = "사과", Price = 2400 },
            new Product() { Name = "바나나", Price = 1000 },
            new Product() { Name = "배", Price = 3000 }
        };
        list.Sort();

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

