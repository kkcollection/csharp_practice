using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Developer : Employee
    {
        public int NumOfGitRepo { get; set; }
        public double AverageCodeRowsPerProject { get; set; }
        public override int Dividend { get { return (int)(NumOfGitRepo * AverageCodeRowsPerProject)/ Entry.Year-2000; } }

        public Developer(string name, int baseSalary, int year, int numOfGitRepo, double averageCodeRowsPerProject): base(name, year, baseSalary)
        {
            this.AverageCodeRowsPerProject = averageCodeRowsPerProject;
            this.NumOfGitRepo = numOfGitRepo;
        }


    }
}
