using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
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
               dept= JsonSerializer.Deserialize<Department>(fs);
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
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.name = txtName.Text;
                dept.location = txtLocation.Text;

                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Create, FileAccess.Write);

                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
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
    }
}
