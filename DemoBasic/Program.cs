using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Department obj = new Department();    

            //Department dept = new Department();

            //Console.WriteLine(dept.GetData());
            //Department dept2 = new Department(10, "Admin", "Mumbai");
            //Console.WriteLine(dept2.GetData());
            //obj.asigndata();
            //Console.WriteLine(obj.GetData());   

            //Student stud = new Student();

            //Console.WriteLine(stud.GetData());

            //Student stud2 = new Student(10,"Electrical","Abhishek");

            //Console.WriteLine(stud2.GetData());

            Employee emp = new Employee("Samar", 340000);
            emp.CalculateSalary();
            Console.WriteLine(emp);

            Employee emp2 = new Employee("Sooraj", 520000);
            emp2.CalculateSalary();
            Console.WriteLine(emp2);

            Employee emp3 = new Employee("Sunny", 410000);
            emp3.CalculateSalary();
            Console.WriteLine(emp3);

            Console.WriteLine("Total count of emp = "+Employee.GetCount());


            SalesManager salesMang = new SalesManager("Sarvesh",50000,12000,10000,7800);
            salesMang.CalculateSalary();
            Console.WriteLine(salesMang);

            Calculation cal = new Calculation();
            Console.WriteLine( cal.Addition(10, 20));
            Console.WriteLine(cal.Addition(10,40,30));
            Console.WriteLine(cal.Addition(10, 50.10));
            
            
        }
    }
}
