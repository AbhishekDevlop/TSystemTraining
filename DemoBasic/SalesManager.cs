using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    public  class SalesManager : Employee
    {
        double foodAllow, comm, ta;
        public SalesManager():base()
        {

        }
        public SalesManager(int id, String name, int salary, double foodAllow,double comm,double ta):base(id,name,salary)
        {
            this.foodAllow = foodAllow;
            this.ta = ta;
            this.comm = comm;
        }
        public override void CalculateSalary()
        {
            hra = basicSalary * 0.40;
            da = basicSalary * 0.20;
            pf = basicSalary * 0.12;
            grossSalary = (basicSalary + hra + da+ta +comm+foodAllow) - pf;
        }

        public override string ToString()
        {
            return "Employee id " + id + " Employee name " + name + " Employee grossSalary " + grossSalary;
        }
    }
}
