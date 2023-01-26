using System;
namespace task2
{
    internal class Product
    {
        public string Name;
        public double Price;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}; Price: {Price}");
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}


