using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ListaExecicioFixaçao
{
    class Employee
    {
        public int Integer { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int integer, string name, double salary)
        {
            Integer = integer;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Integer +
            ", " +
            Name +
            ", " +
            Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
        
    }
}
