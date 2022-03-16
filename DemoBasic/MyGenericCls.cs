using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    public class MyGenericCls <T>
    {
        private T data;

        public MyGenericCls(T data)
        {
            this.data = data;
        }
        public T GetData() 
        {
            return data;
        }
    }
}
