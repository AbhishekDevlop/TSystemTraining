using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    [Serializable]
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public float  productPrice { get; set; }
    }
}
