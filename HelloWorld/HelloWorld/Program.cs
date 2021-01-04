using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, what do you want your new company name to be?");
            string companyName = Console.ReadLine();
            Company company1 = new Company(companyName);
            Console.WriteLine($"You've started the company: {company1.Name}!");


            string doneHiring;
            while (true)
            {
                Console.WriteLine("Would you like to hire an employee?");
                doneHiring = Console.ReadLine();
                if (doneHiring.ToLower() == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("What is their name?");
                    string employeeName = Console.ReadLine();
                    Console.WriteLine("How old are they?");
                    string employeeAge = Console.ReadLine();
                    Console.WriteLine("What is their role?");
                    string employeeTitle = Console.ReadLine();
                    Person personNew = new Person(employeeName, employeeTitle, Int32.Parse(employeeAge));
                    Console.WriteLine(personNew.introduce());
                    company1.HireNewEmployee(personNew);
                }

            }


            string moreThanOneEmployee = company1.Employees.Count > 1 ? "s" : "";
            Console.WriteLine($"You have {company1.Employees.Count} employee{moreThanOneEmployee}");

            Console.WriteLine("Your employees are as follows:");
            foreach (Person employee in company1.Employees)
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine("Please input the year and the income one at a time. Type \"Done\" when finished.");
            string doneAddingIncome;
            while (true)
            {
                Console.WriteLine("Year:");
                doneAddingIncome = Console.ReadLine();
                if (doneAddingIncome.ToLower() == "done")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Company income:");
                    string companyIncome = Console.ReadLine();
                    company1.AddYearlyStats(Int32.Parse(doneAddingIncome), Convert.ToDouble(companyIncome));
                }

            }

            Console.WriteLine("Here are your yearly income stats:");
            foreach(KeyValuePair<int, double> kvp in company1.YearlyIncomes)
            {
                Console.WriteLine($"In {kvp.Key}, you made: {kvp.Value}");
            }
            
        }

        
    }
}
