using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class NameException:Exception
    {
        public NameException(string msg):base(msg)
        {

        }
    }
}
