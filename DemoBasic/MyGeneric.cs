using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
     class MyGeneric
    {
        //GENERIC METHOD
        public void Swap <T>(ref T a,ref T b) 
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
