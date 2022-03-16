using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16March
{
    internal class Category
    {
        int id;
        string name;

        public Category()
        {

        }

        public Category(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "Category Name: "+name+" => Category Id: "+id;
        }
    }
}
