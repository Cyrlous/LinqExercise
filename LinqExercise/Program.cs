using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of Numbers:");
            Console.WriteLine("--------------");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of Numbers:");
            Console.WriteLine("--------------");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            var ascendingNumbers = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("Numbers ordered by ascending:");
            Console.WriteLine("--------------");
            ascendingNumbers.ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console
            var descendingNumbers = numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine("Numbers ordered by descending:");
            Console.WriteLine("--------------");
            descendingNumbers.ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            var highNumbers = numbers.Where(x => x > 6).ToList();
            Console.WriteLine("Numbers above 6:");
            Console.WriteLine("--------------");
            highNumbers.ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var fourNumbers = numbers.OrderBy(x => x).Take(4);
            Console.WriteLine("Only print four numbers:");
            Console.WriteLine("--------------");
            foreach (var number in fourNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            var ageNumbers = numbers.Select((x, index) => index == 4 ? 44 : x).OrderByDescending(x => x).ToList();
            Console.WriteLine("Numbers with index 4 replaced by age:");
            Console.WriteLine("--------------");
            ageNumbers.ForEach(Console.WriteLine);
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var namedEmployees = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName).ToList();
            Console.WriteLine("Employee name starting with 'C' and 'S':");
            Console.WriteLine("--------------");
            foreach (var employee in namedEmployees)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var agedEmployees = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList();
            Console.WriteLine("Employee names in order of age and name:");
            Console.WriteLine("--------------");
            foreach (var employee in agedEmployees)
            {
                Console.WriteLine($"Name: {employee.FullName}\tAge: {employee.Age}");
            }
            Console.WriteLine();

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Add an employee to the end of the list without using employees.Add()
            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
