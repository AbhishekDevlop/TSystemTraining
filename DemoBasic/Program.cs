using System;
using System.Collections;
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

            //Employee emp = new Employee("Samar", 340000);
            //emp.CalculateSalary();
            //Console.WriteLine(emp);

            //Employee emp2 = new Employee("Sooraj", 520000);
            //emp2.CalculateSalary();
            //Console.WriteLine(emp2);

            //Employee emp3 = new Employee("Sunny", 410000);
            //emp3.CalculateSalary();
            //Console.WriteLine(emp3);

            //Console.WriteLine("Total count of emp = "+Employee.GetCount());


            //SalesManager salesMang = new SalesManager("Sarvesh",50000,12000,10000,7800);
            //salesMang.CalculateSalary();
            //Console.WriteLine(salesMang);

            //Calculation cal = new Calculation();
            //Console.WriteLine( cal.Addition(10, 20));
            //Console.WriteLine(cal.Addition(10,40,30));
            //Console.WriteLine(cal.Addition(10, 50.10));

            int[] rainfall = new int[5] { 101, 110, 102, 107, 108 };

            string[] name = new string[] { "Sooraj", "Abhis   hek", "Dhiraj" };

            int[] list1 = new int[3];

            //DISPALY RAINFALL ARRAY
            Console.WriteLine("Displaying Array rainfall");
            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);
            }
            Console.WriteLine("=======================================");

            //COPY FUNCTION
            Array.Copy(rainfall, 2, list1, 0, 3);
            Console.WriteLine("Displying Array after copyed to list1");
            foreach (int i in list1) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=======================================");

            //SORT FUNCTION
            Array.Sort(rainfall);
            Console.WriteLine("Displying Array rainfall after sorting");
            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);
            }
            Console.WriteLine("=======================================");

            //CLEAR FUNCTION
            Array.Clear(rainfall, 3, 2);
            Console.WriteLine("Displaying Array rainfall after using clear funiction ");
            for(int i = 0; i < rainfall.Length; i++) 
            {
                Console.WriteLine(rainfall[i]);
            }
            Console.WriteLine("=======================================");

            //DISPLAY NAME ARRAY
            Console.WriteLine("Displying name Array");
            foreach (string nm in name)
            {
                Console.WriteLine(nm);
            }
            Console.WriteLine("=======================================");

            //SORTING NAME ARRAY
            Array.Sort(name);
            Console.WriteLine("Displying name Array after sorting");
            foreach (string nm in name)
            {
                Console.WriteLine(nm);
            }
            Console.WriteLine("=======================================");


            Product pro = new Product(10, "ABC", 6000f);
            pro.Bill();
            Console.WriteLine(pro);


            Product pro2 = new Product(11, "CD", 4000f);
            pro2.Bill();
            Console.WriteLine(pro2);
            Console.WriteLine("=======================================");

            Student2 stu = new Student2(1, "Sarvesh", 50.23f);
            Console.WriteLine(stu.Result());

            Student2 stu2 = new Student2(2, "Sooraj", 39.0f);
            Console.WriteLine(stu2.Result());
            Console.WriteLine("=======================================");


            //int[,] listed = new int[6, 3];

            ////TO Accept The value 
            //Console.WriteLine("Enter values");
            //for (int i = 0; i < listed.GetLength(0); i++)
            //{
            //    for(int j = 0; j < listed.GetLength(1); j++) 
            //    {
            //          listed[i, j] = int.Parse(Console.ReadLine()); // Accepting data from user 
            //        //listed[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
                        
            //}

            //// DISPLAY 2D ARRAY
            //for (int i = 0; i < listed.GetLength(0); i++)
            //{
            //    for (int j = 0; j < listed.GetLength(1); j++)
            //    {
            //        Console.Write(listed[i,j]+" ");  //Displying data/values
            //    }
            //    Console.WriteLine();
            //}


            // ARRAYlIST

            ArrayList nonGen = new ArrayList();

            nonGen.Add(10);
            nonGen.Add("Abhishek");
            nonGen.Add(true);
            nonGen.Add(false);
            nonGen.Add(12.45f);
            nonGen.Add(12.124);

            foreach (var item in nonGen)
            {
                Console.WriteLine(item);
            }

            nonGen = new ArrayList();

            //STACK 

            Stack stack = new Stack();  
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push("Samar");
            stack.Push("Sarvesh");
            //DISPLAY STACK
            Console.WriteLine("========Displaying Stack=====");
            foreach (var item in stack) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================");
            Console.WriteLine( stack.Pop());

            Console.WriteLine("========Displaying Queue=====");
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue("Abhishek");
            queue.Enqueue(30);

            //DISPLAY QUEUE
            foreach (var item in queue) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================");
            Console.WriteLine( queue.Dequeue());

            //HASHTABLE 

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "First");
            hashtable.Add(4, "Forth");
            hashtable.Add(2, "Second");
            hashtable.Add(3, "Third");
            Console.WriteLine("===============Displying hastable======");
            foreach(DictionaryEntry entry in hashtable) 
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }

            //GENERIC LIST
            Console.WriteLine("=====Generic List====");
            List<Product> productlist = new List<Product>()
            {
                new Product(1,"Laptop",89000.0f),
                new Product(2,"Tab",56000.0f),
                new Product(3, "Mobile", 75000.0f)
            };
            foreach(Product product in productlist) 
            {
                Console.WriteLine(product);
            }

            // GENERIC STACK
            Console.WriteLine("====DISPLAYING GENERIC STACK======");

            Stack<string> sta = new Stack<string>();
            sta.Push("RAJU");
            sta.Push("SHAM");
            sta.Push("BABURAO");

            foreach (string stas in sta)
            {
                Console.WriteLine(stas);
            }

            // GENERIC QUEUE
            Console.WriteLine("====DISPLAYING GENERIC QUEUE======");
           
            Queue<int> que = new Queue<int>();
            que.Enqueue(12);
            que.Enqueue(13);
            que.Enqueue(14);
                que.Enqueue(15);
                que.Enqueue(16);

            foreach (int q in que)
            {
                Console.WriteLine(q);
            }

            //DICTIONARY GENERIC TYPE
            Console.WriteLine("====DISPLAYING GENERIC DICTIONARY======");

            Dictionary<int,String> dic = new Dictionary<int,String>();
            dic.Add(1, "RAJU");
            dic.Add(2, "SHAM");
            dic.Add(3, "KACHARASHETH");
            dic.Add(4, "MADHAV");
            dic.Add(5, "BABURAO");

            foreach (KeyValuePair<int,string> item in dic) 
            {
                Console.WriteLine(item.Key +""+item.Value);
            }

            //GENERIC CLASS
            Console.WriteLine("=====Generic class=====");

            MyGenericCls<string> mg1 = new MyGenericCls<string>("Abhishek");
            Console.WriteLine(mg1.GetData());
            Console.WriteLine("====================");

            MyGenericCls<Product> mg2 = new MyGenericCls<Product>(new Product (78, "EarPhone", 8012.0f));
            Console.WriteLine(mg2.GetData());
            Console.WriteLine(  "===========================");

            MyGenericCls<int> mg3 = new MyGenericCls<int>(10);
            Console.WriteLine(mg3.GetData());

            //  GENERIC METHOD

            Console.WriteLine("=========Generic Method============");

            MyGeneric gen = new MyGeneric();

            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swaping a = {a} and b = {b}");
            gen.Swap(ref a, ref b);
            Console.WriteLine($"After Swaping a={a} and b = {b}");


            //AUTO IMPLEMENTED PROPERTIES
            Console.WriteLine("=======Auto Implemented Properties=========");
            Dept d1 = new Dept();
            d1.depId = 10;
            d1.depName = "Abhishek";
            Console.WriteLine(d1.depName+ " "+d1.depId);

            Dept d2 = new Dept{depId=12,depName="Aditya" };
            Console.WriteLine(d2.depName+" "+d2.depId);
            

        }
    }
}
 