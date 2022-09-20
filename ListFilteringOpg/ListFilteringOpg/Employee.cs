using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFilteringOpg
{
    internal class Employee : Person
    {
        internal int employeeId;
        internal Employee(string? name, int age, int employeeId) 
            : base(name, age)
        {
            this.employeeId = employeeId;
        }

    }
}
