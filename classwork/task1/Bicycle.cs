using System;
namespace task1
{
    internal class Bicycle
    {
        public string Brand;
        public string Model;
        public double Mileage;


        public void Drive(double km)
        {
            Mileage += km;
        }
    }
}
