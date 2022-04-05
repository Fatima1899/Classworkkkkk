using Classworkkk.Models;
using Newtonsoft.Json;
using System;
using System.IO;


namespace Classworkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\tu7crxtt4\source\repos\Classworkkk\Classworkkk\Files");
            
            if (!File.Exists (@"C:\Users\tu7crxtt4\source\repos\Classworkkk\Classworkkk\Files\database.json"))
            {
                File.Create(@"C:\Users\tu7crxtt4\source\repos\Classworkkk\Classworkkk\Files\database.json");
            }

            Employee employee1 = new Employee() 
            {
                Id = 1,
                Name = "Test1",
                Salary = 123
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                Name = "Test2",
                Salary = 124
            }; ;

            Department department = new Department() 
            {
                Id = 1,
                Name = "TEst department"
            };
            department.Add(employee1);
            department.Add(employee2);

            string result = JsonConvert.SerializeObject(department);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\tu7crxtt4\source\repos\Classworkkk\Classworkkk\Files\database.json"))
            {
                sw.WriteLine(result);
            }
        }
    }
}
