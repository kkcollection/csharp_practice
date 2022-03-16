using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Program
    {
         // class, object, access modifiers, abstract, inheritance, polymorphism

        static void Main(string[] args)
        {
            Employee jane = new Manager("Jane Doe", 2002, 875000, 20);

            // bool possible = jane is Developer;
            // bool possible = jane is Manager;
            // bool possible = jane is Employee;
             bool possible = jane is Object;

            if (jane is Manager)
            {
                Manager jane2 = jane as Manager;
            }


            Employee[] employees = new Employee[9];
            employees[0] = new Manager("Random One", 2001, 800000, 4);
            employees[1] = new Manager("Jhone One", 2002, 700000, 2);
            employees[2] = new Manager("Jhone Done", 2004, 870000, 2);
            employees[3] = new Salesman("Random Two", 2002, 806000, 3); 
            employees[4] = new Salesman("Random Three", 2012, 85000, 1);
            employees[5] = new Salesman("Random Four", 2014, 806000, 5);
            employees[6] = new Developer("Random Five", 2005, 900000, 4,1000);
            employees[7] = new Developer("Random Six", 2007, 300000, 3,800);
            employees[8] = new Developer("DoubleOh Seven", 2010, 400000, 2,600);

            Console.WriteLine(BiggestSalary(employees));
        }

        static string BiggestSalary(Employee[] employees)
        {
            int maxindex = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Dividend > employees[maxindex].Dividend)
                {
                    maxindex = i;
                }
            }
            return employees[maxindex].Name;
        }

    }
}
