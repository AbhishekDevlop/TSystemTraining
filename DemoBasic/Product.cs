using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    internal class Product
    {
       int  productCode ;
        string productName ;
        float productPrice ;

        public Product(int productCode,string productName,float productPrice)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.productPrice = productPrice;
        }
        public void Bill() 
        {
            if (productPrice > 5000)
                productPrice *= 0.90f;
        }

        public override string ToString() 
        {
            return "Product Name: " + productName + "\n Product Code:" + productCode + "\n Product Price " + productPrice;
        }
    }

}
