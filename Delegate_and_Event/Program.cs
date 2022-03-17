using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            CalDelegate calculateAdd = new CalDelegate(cal.Addition);
            int result = calculateAdd.Invoke(20, 10);
            Console.WriteLine("Addition = "+result);

            CalDelegate calculateSub = new CalDelegate(cal.Substraction);
            result = calculateSub.Invoke(20, 10);
            Console.WriteLine("Substraction"+result);
            Console.WriteLine("===========================");

            //TO UPPERCASE DELEGATE
            Test t =  new Test();
            NameDelegate namDel = new NameDelegate(t.ToUpperCase);
            string name = namDel.Invoke("Abhishek");
            Console.WriteLine("Name  = "+name);
            Console.WriteLine("=================================");

            Console.WriteLine("=========Multicast Delegate======");
            //Multicast Delegate

            Calculation cal1 = new Calculation();
            CalDelegate calculate = new CalDelegate(cal1.Addition);
            calculate += new CalDelegate(cal1.Substraction);
            calculate += new CalDelegate(cal1.multiplication); // adding in Invocation list

            Delegate[] list = calculate.GetInvocationList();

            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(20, 10));
            }
            Console.WriteLine("========================================");

            //Multicaste Delegate
            
            Test t1 = new Test();
            NameDelegate nameDelegate = new NameDelegate(t1.ToUpperCase);
            nameDelegate += new NameDelegate(t1.ToLowerCase);

            Delegate[] names = nameDelegate.GetInvocationList();
            
            foreach(Delegate item in names) 
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke("Abhishek"));

            }
        }
    }
}
