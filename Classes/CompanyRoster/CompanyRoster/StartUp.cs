using System;
using System.Collections.Generic;
using System.Linq;


namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            var departmentAvaregeSalary = new Dictionary<string,List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var salary = double.Parse(input[1]);
                var position = input[2];
                var department = input[3];


                var employee = new Employee(name,salary,position,department);

                if (!departmentAvaregeSalary.ContainsKey(department))
                {
                    departmentAvaregeSalary[department] = new List<double>();
                }
                departmentAvaregeSalary[department].Add(salary);

                if (input.Length > 4)
                {
                    if (input.Length == 5)
                    {
                        var age = 0;
                        var isAge = int.TryParse(input[4], out age);
                        if (isAge)
                        {
                            employee.Age = age;
                        }
                        else
                        {
                            employee.Email = input[4];
                        }
                    }
                    else
                    {
                        employee.Email = input[4];
                        employee.Age = int.Parse(input[5]);

                    }
                }
                employees.Add(employee);
            }
            var result = departmentAvaregeSalary.OrderByDescending(e => e.Value.Average())
                .First(
                );
            var highestAverageDep = result.Key;
            Console.WriteLine($"Highest Average Salary: {highestAverageDep}");

            var employeesFromHigherstAvDep = employees
                .Where(e => e.Department == highestAverageDep)
                .OrderByDescending(e => e.Salary)
                .ToList();
            foreach (var employee in employeesFromHigherstAvDep)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
