using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Manager : Employee
    {
        public int NumOfSubordinates {get;set;}
        public override int Dividend { get { return ((int)(DateTime.Now - Entry).TotalDays / 365) * NumOfSubordinates * 5000;  } }
        public Manager(string name, int year, int baseSalary, int numberOfSubordinates):base(name,year,baseSalary)
        {
            this.NumOfSubordinates = numberOfSubordinates;
        }
    }
}
