using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Product
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
        public void print() 
        {
            Console.WriteLine($"Product Name: {productName}, Product Id: {productId}, Product Price: {productPrice}");
        }
    }

    public class Student 
    {
    }
}
