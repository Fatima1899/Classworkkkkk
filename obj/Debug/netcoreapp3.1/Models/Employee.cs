using System;
using System.Collections.Generic;
using System.Text;

namespace Classworkkk.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}\nName:{Name}\nSalary:{Salary}");
        }
    }
}
