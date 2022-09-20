using myproje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproje
{
    public class employee
    {

        protected string name;
        protected string title;
        protected decimal salary;
        protected int seniority;
        public employee(string name, string title, decimal salary, int seniority)
        {
            this.name = name;
            this.title = title;
            this.salary = salary;
            this.seniority = seniority;
        }
        protected virtual decimal CalculateYearlySalary()
        {
            decimal yearlySalary;
            yearlySalary = salary * 12;
            yearlySalary += (yearlySalary / 10) * seniority;
            return yearlySalary;
        }
    }
}


