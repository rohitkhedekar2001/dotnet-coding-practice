using Coding_Practice.Model;
using System.Text.Json;
namespace Coding_Practice.Service
{
    public class BegginerrCodingQuestion : IBegginerrCodingQuestion
    {      

        public string reverseastring(string abc)
        {
            string reverse = "";
            for (int i=abc.Length-1;i>=0;--i)
            {
                reverse+=abc[i];
            }
            return reverse;
        }

        public List<Employee> GetActiveITEmployees()
        {
            var employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Rohit",
                Department = "IT",
                Salary = 60000,
                IsActive = true
            },
            new Employee
            {
                Id = 2,
                Name = "Amit",
                Department = "HR",
                Salary = 45000,
                IsActive = true
            },
            new Employee
            {
                Id = 3,
                Name = "Pavan",
                Department = "IT",
                Salary = 80000,
                IsActive = false
            },
            new Employee
            {
                Id = 4,
                Name = "Raj",
                Department = "IT",
                Salary = 70000,
                IsActive = true
            },
            new Employee
            {
                Id = 5,
                Name = "Neha",
                Department = "HR",
                Salary = 55000,
                IsActive = true
            }
        };

            var result = employees
                .Where(x => x.Department == "IT" && x.IsActive)
                .ToList();

            var result1 = employees.Where(x => x.Salary > 6000);

            

            return result;
        }

        
    }
}
