using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Salesman : Employee
    {
        public int Concluded_Deal {get;set;}
        public override int Dividend { get { return Concluded_Deal * 10000; } }
        public Salesman(string name, int year, int baseSalary, int concluded_Deal) : base(name,year,baseSalary)
        {
            this.Concluded_Deal = concluded_Deal;
        }
    }
}
