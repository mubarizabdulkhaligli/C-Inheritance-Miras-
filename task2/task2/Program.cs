using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Iphone", 2500) { Camera = 16 };
            Notebook notebook = new Notebook("Macbook", 5000) { RAM = 8, Storage = 512 };
            Product product = new Product("Coca-cola", 2);

            product.ShowInfo();
            notebook.ShowInfo();
            phone.ShowInfo();
        }
    }
}



