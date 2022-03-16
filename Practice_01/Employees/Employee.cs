using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    abstract class Employee
    {
        public string Name { get; set; }

        protected DateTime Entry { get; set; }

        public int BasicSalary { get; set; }

        public abstract int Dividend { get; }
        public Employee(string name, int year, int baseSalary)
        {
            this.Name = name;
            this.BasicSalary = baseSalary;
            this.Entry = new DateTime(year, 1, 1);
        }

        /*class Employee
        {
            public string Name { get; set; }

            protected DateTime Entry { get; set; }

            public int BasicSalary { get; set; }

            public virtual int Dividend { get { return 0; } }
            public Employee(string name, int year, int baseSalary)
            {
                this.Name = name;
                this.BasicSalary = baseSalary;
                this.Entry = new DateTime(year, 1, 1);
            }
        }*/
    }
    }
