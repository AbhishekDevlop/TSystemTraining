using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Keyword
{
    internal class Operations
    {
        public void Calculation(int n1, int n2,out int add, out int mul,out int sub) 
        {
            add = n1 + n2;
            sub = n1 - n2;
            mul = n1 * n2;
        }
    }
}
