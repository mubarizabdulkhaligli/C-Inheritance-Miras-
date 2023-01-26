using System;
namespace task2
{
    internal class Notebook : Product
    {
        public int RAM;
        public int Storage;

        public Notebook(string name, double price) : base(name, price)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}; Price: {Price}; RAM: {RAM}; Storage: {Storage}");
        }
    }
}

