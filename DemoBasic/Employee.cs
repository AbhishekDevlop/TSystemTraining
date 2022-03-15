using System;


namespace DemoBasic
{
    public class Employee
    {
        protected static int count; // to assign emp id  
        protected int id;
        protected string  name;
        protected int basicSalary;
        protected double da, hra, pf,grossSalary;
        public Employee()
        {
            count++;    // increment
            id = count;
        }
        public Employee(String name,int salary)
        {
            count++;
            this.id = count;
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

        public static int GetCount() 
        {
            return count;
        }

    }
}
