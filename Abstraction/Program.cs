using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10,20);         
            rect.area();
            Console.WriteLine(rect);

            Circle cir = new Circle(9);
            cir.area();
            Console.WriteLine(cir);

        }
    }
}
