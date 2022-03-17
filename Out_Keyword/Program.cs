using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 10;
            int add, mul, sub;

            Operations op = new Operations();
            op.Calculation(a,b,out add,out mul,out sub);
            Console.WriteLine($"{a} + {b} = {add}");
            Console.WriteLine($"{a} - {b} = {sub}");
            Console.WriteLine($"{a} * {b} = {mul}") ;
        }
    }
}
