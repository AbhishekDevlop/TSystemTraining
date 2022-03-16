using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16March
{
    internal class Employee
    {
        int empId;
        string empName;
        float empSalary;

        public Employee()
        {
            
        }
        public Employee(int id,string name,float salary)
        {
            this.empId = id;
            this.empName = name;
            this.empSalary = salary;
        }

        public override string ToString()
        {
            return "Employee Name : " + empName + " Employee Id: " + empId + " Employee Salary: " + empSalary;
        }
    }
}
