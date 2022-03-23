using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace Serialization_Demo
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnJasonWrite_Click(object sender, EventArgs e)
        {
            try
            {

                // to store data into product object
                Product product = new Product();
                product.productId = Convert.ToInt32(txtProductId.Text);
                product.productName = txtProductName.Text;
                product.productPrice = Convert.ToSingle(txtProductPrice.Text);

                //to create file and open into write mode
                FileStream fs = new FileStream(@"D:\Product\ProductJasonFile.json", FileMode.Create, FileAccess.Write);

                //Serialize method
                JsonSerializer.Serialize(fs, product);
                fs.Close();
                MessageBox.Show("Json File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {

                Product product = new Product();

                FileStream fs = new FileStream(@"D:\Product\ProductJasonFile.json", FileMode.Open, FileAccess.Read);

                //Deserialize

                product = JsonSerializer.Deserialize<Product>(fs);

                txtProductId.Text = product.productId.ToString();
                txtProductName.Text = product.productName;
                txtProductPrice.Text = product.productPrice.ToString();
             }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try 
            {
                //to store data into object
                Product product = new Product();

                product.productId = Convert.ToInt32(txtProductId.Text);
                product.productName = txtProductName.Text;
                product.productPrice = Convert.ToSingle(txtProductPrice.Text);

                //To Create file and open it into the write mode
                FileStream fs = new FileStream(@"D:\Product\ProductSOAPFile.soap", FileMode.Create, FileAccess.Write);

                //To Serialize

                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, product);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try 
            {
                Product product = new Product();

                FileStream fs = new FileStream(@"D:\Product\ProductSOAPFile.soap",FileMode.Open,FileAccess.Read);

                SoapFormatter sf = new SoapFormatter();
                product = (Product) sf.Deserialize(fs);

                txtProductId.Text = product.productId.ToString();
                txtProductName.Text = product.productName;
                txtProductPrice.Text = product.productPrice.ToString();

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try 
            {
                // To store data into object
                Product product = new Product();
                product.productId = Convert.ToInt32(txtProductId.Text);
                product.productName = txtProductName.Text;
                product.productPrice = Convert.ToSingle(txtProductPrice.Text);

                //To create a file and open it into write mode

                FileStream fs = new FileStream(@"D:\Product\ProductXmlFile.xml", FileMode.Create, FileAccess.Write);
                
                //to serialize

                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, product);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try 
            {
                Product product = new Product();

                FileStream fs = new FileStream(@"D:\Product\ProductXmlFile.xml", FileMode.Open, FileAccess.Read);

                XmlSerializer xs = new XmlSerializer (typeof(Product));
                product =(Product) xs.Deserialize(fs);

                txtProductId.Text = product.productId.ToString();
                txtProductName.Text = product.productName;
                txtProductPrice.Text = product.productPrice.ToString();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try 
            {
                // to store a data into the object
                Product product = new Product();
                product.productId= Convert.ToInt32(txtProductId.Text);
                product.productName= txtProductName.Text;
                product.productPrice= Convert.ToSingle(txtProductPrice.Text);

                //to create file and open it into write mode
                FileStream fs = new FileStream(@"D:\Product\ProductBinaryFile.dat", FileMode.Create, FileAccess.Write);
                
                //to serialise
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, product);
                fs.Close();
                MessageBox.Show("File Added");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try 
            {
                 
                Product product = new Product();

                FileStream fs = new FileStream(@"D:\Product\ProductBinaryFile.dat", FileMode.Open, FileAccess.Read);

                // to deserialize
                BinaryFormatter bf = new BinaryFormatter();
                product = (Product)bf.Deserialize(fs);

                txtProductId.Text = product.productId.ToString();
                txtProductName.Text = product.productName;
                txtProductPrice.Text = product.productPrice.ToString();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
