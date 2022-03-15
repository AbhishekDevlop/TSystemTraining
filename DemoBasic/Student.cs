using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    internal class Student
    {
        private int id;
        private string DepartmentName;
        private string name;

        public Student()
        {
            id = 1;
            DepartmentName = "CS";
            name = "Samar";
        }

        public Student (int sid,String deptName,string sName) 

        {
            id = sid;
            DepartmentName = deptName;
            name = sName;
        }

        public string GetData() 
        {
            return "Student Name : " + name + " , Student Id : " + id + " , Student Department Name: " + DepartmentName;
        }
    }
}
