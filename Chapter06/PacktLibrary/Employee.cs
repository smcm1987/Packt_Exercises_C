using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    public class Employee : Person
    {
        public string? EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }

        public new void WriteToConsole()
        {
            WriteLine($"{Name} was born {DateOfBirth:dd/MM/yy} and hired on {HireDate:dd/MM/yy}");
        }
    }
}
