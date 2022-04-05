using System;
using System.Collections.Generic;
using System.Text;

namespace Classworkkk.Models
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List <Employee> _employees;
        public Department()
        {
            _employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
