using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    [Serializable] // it is tell the runtime that class is allow to serialize
    public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
    }
}
