using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    internal class Student2
    {
        int rollNo;
        string name;
        float percent;
        public Student2(int rollNo,string name,float percent)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.percent = percent;
        }
        public string Result() 
        {
            if (percent < 40)
            
                return $"Result of {name}: "+ "Fail";
            
            else
                return $"Result of {name}: "+"Pass";

        }
    }
}
