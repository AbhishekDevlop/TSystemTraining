using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  LIST OF FOOD
            List<Food> foodList = new List<Food>();
            foodList.Add(new Food("Puran Poli",1200.12f));
            foodList.Add(new Food("Basundi", 512.23f));
            foodList.Add(new Food("Jilebi", 854.12f));

            //DISPLAYING LIST OF FOOD
            Console.WriteLine("=======List of Food======");
            foreach (Food foods in foodList) 
            {
                Console.WriteLine(foods);
            }


            //LIST OF CATEGORY
            Console.WriteLine("=====List Of Category======");
            List<Category> catg = new List<Category>()
            {
                new Category(822,"Hoodies"),
                new Category(124,"T-Shirt"),
                new Category(345,"Shirt")
                
             };

            //Displying List of Category 
            foreach(Category catgs in catg) 
            {
                Console.WriteLine(catgs);
            }

            // Create Array Of Employee

            Employee[] emp = new Employee[5]
            {
               new Employee(1,"Abhishek",120000.12f),
               new Employee(2,"Sarvesh",100000.00f),
               new Employee(3,"Dhiraj",110000.1f),
               new Employee(4,"Anirudhha",80000.88f),
               new Employee(5,"Himanshu",70000.0f),
            };

            //Display Array of Employee
            Console.WriteLine("=======Displaying Array of Employee Details======");
            foreach(Employee employees in emp) 
            {
                Console.WriteLine(employees);
            }

            //Create List Of Product

            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 11, Name = "Television", price = 54000.00f });//Object Initializer
            products.Add(new Product() { Id = 12, Name = "Fridge", price = 45000.00f });
            products.Add(new Product() { Id = 13, Name = "Air Conditioner", price = 84000.00f });

            //Displaying List Of Product
            Console.WriteLine("=====Displaying List Of Product=======");
            foreach(Product prod in products) 
            {
                Console.WriteLine($"Product Name => {prod.Name}, Product Id=> {prod.Id}, Product Price=> {prod.price}");
            }

            //Create List Of Student 

            List<Student> student = new List<Student>()
            {
               new Student(){rollNo=01,name= "Abhishek",percentage= 99.99f}, // using Object Initializer syntax
               new Student(){rollNo=02,name ="Sarvesh",percentage=98.98f},
               new Student() {rollNo=03,name="Dhiraj",percentage=99.00f}
            };

            //Displaying Student List
            Console.WriteLine( "========Displaying List Of Students =========");
            foreach(Student students in student) 
            {
                Console.WriteLine($"Student Name => {students.name},  Student ROllNo. => {students.rollNo}, Student Percentage => {students.percentage}");
            }
        }
    }
}
