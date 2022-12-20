using System;
using System.Security.Cryptography.X509Certificates;

namespace constuctor_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "X6", 0, 45, 30);

            
            Console.WriteLine(car1.AddFuel(10));

            Console.WriteLine("Nece dene isci olacaq:");
            var numStr = Console.ReadLine();
            var num = Convert.ToInt32(numStr);
            Employee[] employees = new Employee[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Iscinin tam adini daxil edin:");
                var fullname = Console.ReadLine();
                
                Console.WriteLine("Iscinin yasini daxil edin:");
                var ageStr = Console.ReadLine();
                int age = Convert.ToInt32(ageStr);
               
                Console.WriteLine("Iscinin maasini daxil edin:");
                var salaryStr = Console.ReadLine();
                int salary = Convert.ToInt32(salaryStr);
                
                Console.WriteLine("Iscinin pozisiyasini daxil edin:");
                var position = Console.ReadLine();

                employees[i] = new Employee(fullname,age,salary,position);
            }
            Console.WriteLine("Axtarıs etmek isteyirsinizmi? y/n");

            bool has = true;
            var value = Console.ReadLine();//Burda yungun bir problem varki Console.Readline-i ikidefe verir. Amma buna gorede bal kesmezsizdeeee o boyda kod yazmisam.
            
            do
            {
                  
                 
                if (value != "y" && value != "n")
                {
                    Console.WriteLine("Sadece 'y' ve 'n' herflerinden istifade etmelisiniz");
                    has = false;

                }

            } while (has == false);

                if(value == "y")
                {
                    bool deyer = false;
                    
                    do
                    {
                     Console.WriteLine("Bir axtaris deyerini onun evvelinde yazinal reqeme gore secin:");
                     Console.WriteLine("1:Ad" +
                                      "2:Yas" +
                                      "3:Maas" +
                                      "4:Pozisiya");
                        var axtarisdeyeriStr = Console.ReadLine();
                        var axtarisdeyeri = Convert.ToInt32(axtarisdeyeriStr);

                        if (axtarisdeyeri == 1)
                        {
                            deyer = true;
                            bool FindName = false;
                            Console.WriteLine("Axtardixiniz iscinin adini daxil edin:");
                            var iscininadi = Console.ReadLine();
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i].FullName == iscininadi)
                                {
                                    Console.WriteLine(employees[i].GetInfo());
                                    FindName = true;
                                }
                            }
                            if(FindName == false)
                            {
                                Console.WriteLine("Bele bir isci tapilmadi");
                            }

                        }
                        else if (axtarisdeyeri == 2)
                        {
                            deyer = true;
                            bool FindAge = false;
                            Console.WriteLine("Axtardixiniz iscinin yasini daxil edin:");
                            var iscininyasiStr = Console.ReadLine();
                            int iscininyasi = Convert.ToInt32(iscininyasiStr);

                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i].Age == iscininyasi)
                                {
                                    Console.WriteLine(employees[i].GetInfo());
                                    FindAge = true;
                                }
                            }
                            if (FindAge == false)
                            {
                                Console.WriteLine("Bele bir isci tapilmadi");
                            }
                        }
                        else if (axtarisdeyeri == 3)
                        {
                            deyer = true;
                            bool FindSalary = false;
                            Console.WriteLine("Axtardixiniz iscinin maasini daxil edin:");
                            var iscininmaasiStr = Console.ReadLine();
                            int iscininmaasi = Convert.ToInt32(iscininmaasiStr);

                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i].Salary == iscininmaasi)
                                {
                                    Console.WriteLine(employees[i].GetInfo());
                                    FindSalary = true;
                                }
                            }
                            if (FindSalary == false)
                            {
                                Console.WriteLine("Bele bir isci tapilmadi");
                            }
                        }
                        else if(axtarisdeyeri == 4)
                        {
                            deyer = true;
                            bool FindPosition = false;
                            Console.WriteLine("Axtardixiniz iscinin pozisiyasini daxil edin:");
                            var iscininpozisiyasi = Console.ReadLine();
                            

                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i].Position == iscininpozisiyasi)
                                {
                                    Console.WriteLine(employees[i].GetInfo());
                                    FindPosition = true;
                                }
                            }
                            if (FindPosition == false)
                            {
                                Console.WriteLine("Bele bir isci tapilmadi");
                            }
                        }




                    } while (deyer == false);
                }
                else
                {
                    Console.WriteLine("emeliyyat ugurla baslanmadi ;)");
                    
                }


            

            

        }
    }
}
