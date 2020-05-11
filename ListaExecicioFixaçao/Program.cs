using System;
using System.Globalization;
using System.Collections.Generic;
namespace ListaExecicioFixaçao
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("How many employees will be registered? ");
            int registred = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= registred; i++)
            {
                Console.WriteLine("Employee # " + i + ":");
                Console.Write("id: ");
                int intenger = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(intenger, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee copy = list.Find(x => x.Integer == searchId);
            if (copy != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                copy.increaseSalary(porcentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            } 
        }
    }
}
