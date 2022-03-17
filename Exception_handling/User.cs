using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class User
    {
        
        public string UserName (string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Invalid Name Please Enter Valid Name");
            }
                return name;
        }
    }
}
