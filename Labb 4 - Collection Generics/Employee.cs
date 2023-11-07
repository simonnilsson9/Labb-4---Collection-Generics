using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_Generics
{
    internal class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }

        public Employee(string id, string name, string gender, string salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;            
        }

        public void EmployeeInfo()
        {
            Console.WriteLine($"{ID} - {Name} - {Gender} - {Salary}");
        }
    }
}
