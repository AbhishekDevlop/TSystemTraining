using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    public class Employee
    {
        protected int id;
        protected string  name;
        protected int basicSalary;
        protected double da, hra, pf,grossSalary;
        public Employee()
        {

        }
        public Employee(int id,String name,int salary)
        {
            this.id = id;
            this.name = name;
            this.basicSalary = salary;
        }

        public virtual void CalculateSalary()
        {
            hra = basicSalary * 0.40;
            da = basicSalary * 0.20;
            pf = basicSalary * 0.12;
            grossSalary = (basicSalary + hra + da) - pf;
        }

        public override string ToString()
        {
            return "Employee id " + id + " Employee name " + name + " Employee grossSalary " + grossSalary;
        }

    }
}
