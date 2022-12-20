using System;
using System.Collections.Generic;
using System.Text;

namespace constuctor_inheritance
{
    internal class Human
    {
        public Human(string fullname,int age)
        {
            FullName= fullname;
            Age = age;  
        }
        public string FullName;
        public int Age;

    }
}
