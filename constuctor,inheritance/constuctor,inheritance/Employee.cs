using System;
using System.Collections.Generic;
using System.Text;

namespace constuctor_inheritance
{
    internal class Employee : Human
    {
        public Employee(string fullname, int age, int salary, string position) : base(fullname, age)
        {
            Salary = salary;
            Position = position;
        }
        public int Salary;
        public string Position;

        public string GetInfo()
        {
            return $"Fullname:{FullName}" +
                $"Age:{Age}" +
                $"Salary:{Salary}" +
                $"Position:{Position}";
        }
    }
}
