using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Company
    {
        public string Name
        { get; private set; }

        public List<Person> Employees = new List<Person>();

        public Dictionary<int, double> YearlyIncomes  = new Dictionary<int, double>();
     

        public Company(string name)
        {
            this.Name = name;
        }

        public void HireNewEmployee(Person employee)
        {
            Employees.Add(employee);
        }

        public void AddYearlyStats(int year, double income)
        {
            this.YearlyIncomes.Add(year, income);
        }

    }
}
