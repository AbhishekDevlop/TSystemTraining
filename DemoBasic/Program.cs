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

            Student stud = new Student();

            Console.WriteLine(stud.GetData());

            Student stud2 = new Student(10,"Electrical","Abhishek");
             
            Console.WriteLine(stud2.GetData());

        }
    }
}
