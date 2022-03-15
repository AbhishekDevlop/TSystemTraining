using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    internal class Department
    {
        private int id;
        private string name;
        private string location;

        public Department()
        {
            id = 1;
            name = "HR";
            location = "Pune";
    
         }
        public Department(int did, string dNAme,string loc )
        {
                id = did;
            name = dNAme;
            location = loc;
        }

        public void asigndata()
        {
            id = 1;
            name = "hr";
            location = "Amravati";
        }
        public String GetData()
        {
            return "DepartMent id: " + id + "Department Name: " + name + "Department location: " + location;
        }
    }
}
