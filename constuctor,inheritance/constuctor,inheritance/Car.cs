using System;
using System.Collections.Generic;
using System.Text;

namespace constuctor_inheritance
{
    internal class Car:Vehicle
    {
        public Car(string Brand, string Model, int Millage,int fuelcapacity, int currentfuel):base(Brand,Model,Millage)
        {
            FuelCapacity = fuelcapacity;
            CurrentFuel = currentfuel;
        }
        public int FuelCapacity;
        public int CurrentFuel;

        public bool AddFuel(int fuel)
        {
            if(fuel + CurrentFuel> FuelCapacity)
                return false;
            
            else 
                return true;
        } 
    }
}
