using System;
using System.Collections.Generic;
using System.Text;

namespace constuctor_inheritance
{
    internal class Vehicle
    {
        public Vehicle(string brand,string model,int millage)
        {
            Brand = brand;
            Model = model;
            Millage = millage;
        }
        public string Brand;
        public string Model;
        public int Millage;
    }
}
