using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Linq;


namespace Serialization_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //To store data into Object 
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.name = txtName.Text;
                dept.location = txtLocation.Text;

                // Create a File and open in write mode
                FileStream fs = new FileStream(@"D:\Dept.json", FileMode.Create, FileAccess.Write);

                //user serializable method
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\Dept.json", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.name;
                txtLocation.Text = dept.location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // to store data into Object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.name = txtName.Text;
                dept.location = txtLocation.Text;

                //create file and open in write mode
                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Create, FileAccess.Write);

                //use serializable method
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();

                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Open, FileAccess.Read);

                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.name;
                txtLocation.Text = dept.location;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {

            try
            {
                // to store data into object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.name = txtName.Text;
                dept.location = txtLocation.Text;

                //to create a file and open it into write mode 


                FileStream fs = new FileStream(@"D:\DeptBinaryFile.dat", FileMode.Create, FileAccess.Write);

                // use Serialize method
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();

                FileStream fs = new FileStream(@"D:\DeptBinaryFile.dat", FileMode.Open, FileAccess.Read);

                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(fs);

                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.name;
                txtLocation.Text = dept.location;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // to store the data into the object 
                Department dept = new Department();

                dept.Id = Convert.ToInt32(txtId.Text);
                dept.name = txtName.Text;
                dept.location = txtName.Text;

                //To Create a file and open it into write mode

                FileStream fs = new FileStream(@"D:\DeptsoapFile.soap", FileMode.Create, FileAccess.Write);

                // Use Serialize Method
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try 
            {
                Department dept = new Department();

                FileStream fs = new FileStream(@"D:\DeptsoapFile.soap", FileMode.Open, FileAccess.Read);

                SoapFormatter sf = new SoapFormatter();

                // to deserialize 
                dept =  (Department)sf.Deserialize(fs);

                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.name;
                txtLocation.Text = dept.location;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
