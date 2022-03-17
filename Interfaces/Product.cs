using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Product:IPrintable
    {
        int productId;
        string productName;
        float productPrice;

        public Product()
        {
            productId = 1;
            productName = "Pen";
            productPrice = 567.0f;
        }
        public void Print()
        {
            Console.WriteLine("Product Details: ");
            Console.WriteLine($"Product Name: {productName}, Product Id: {productId}, Product Price: {productPrice}");
        }
    }

    public class Student : IPrintable
    {
        int rollNo;
        string name;
        string branch;
        public Student()
        {
            rollNo = 11;
            name = "Himanshu";
            branch = "Electrical";
        }
        public void Print()
        {
            Console.WriteLine("Student Details: ");
            Console.WriteLine($"Student RollNo: {rollNo}, Student Name {name}, Student branch {branch}");
        }

        
    }
    public class Xerox : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }
    }
}
