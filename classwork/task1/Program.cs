using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Bicycle bicycle = new Bicycle();

            bicycle.Brand = "Desna";
            bicycle.Model = "2000";

            bicycle.Drive(30);
            bicycle.Drive(100);
            bicycle.Drive(50);
            bicycle.Drive(20);

            Console.WriteLine(bicycle.Mileage);


            Console.Write("Velosiped sayi: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Bicycle[] bicycles = new Bicycle[count];

            for (int i = 0; i < bicycles.Length; i++)
            {
                string brand;

                do
                {
                    Console.WriteLine("Brand: ");
                    brand = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(brand));

                string model;

                do
                {
                    Console.WriteLine("Model: ");
                    model = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(model));


                Bicycle bicycle1 = new Bicycle
                {
                    Brand = brand,
                    Model = model
                };

                bicycles[i] = bicycle1;
            }

            Console.WriteLine("1. Butun velosipedlere bax");
            Console.WriteLine("2. Velosipedler arasinda model adina gore axtaris et");

            Console.WriteLine("Emeliyyat secin: ");

            string opr = Console.ReadLine();

            if (opr == "1")
            {
                foreach (var item in bicycles)
                {
                    Console.WriteLine($"Brand: {item.Brand}; Model: {item.Model}; Milage: {item.Mileage}");
                }
            }
            else if (opr == "2")
            {
                Console.WriteLine("Model secin: ");
                string wantedModel = Console.ReadLine();

                foreach (var item in bicycles)
                {
                    if (item.Model.Contains(wantedModel))
                        Console.WriteLine($"Model: {item.Model}");
                }
            }
        }
    }
}



