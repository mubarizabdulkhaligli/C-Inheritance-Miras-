using System;
namespace task2
{
    internal class Phone : Product
    {
        public int Camera;

        public Phone(string name, double price) : base(name, price)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}; Price: {Price}; Camera: {Camera}");
        }
    }
}


