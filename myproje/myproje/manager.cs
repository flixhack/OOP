using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproje
{
    class manager : employee
    {
        protected decimal bonus;
        public manager(string name, string title, decimal salary, decimal bonus, int seniority) 
            : base(name, title, salary, seniority)
        {
            this.bonus = bonus;
        }
        protected override decimal CalculateYearlySalary()
        {
            {
                decimal yearlySalary;
                yearlySalary = salary * 12;
                yearlySalary += (yearlySalary / 10) * seniority;
                yearlySalary += bonus;
                return yearlySalary;
            }
        }
    }
}
