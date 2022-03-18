using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace File_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\TestDemo"; // giving path
            DirectoryInfo dir = new DirectoryInfo(path);//directory info obj // passing path
            if (dir.Exists) { MessageBox.Show("Folder already exist");}//if folder already exist
            else 
            {
                dir.Create();
                MessageBox.Show("New folder created");// to create new folder
            }


            //string path = @"D:\Test";
            //if (Directory.Exists(path)) 
            //{
            //    MessageBox.Show("Folder Already Exist");
            //}
            //else
            //{
            //    Directory.CreateDirectory(path);
            //    MessageBox.Show("Folder Created");
            //}
        }

        private void bntCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\TestDemo\Test.txt";
            FileInfo fi = new FileInfo(path);
            if (fi.Exists) { MessageBox.Show("File already exist");} // if file already exist
            else { fi.Create(); MessageBox.Show("New File Created");}// to create new file
            //string path = @"D:\Test\Testdemo.txt";
            //if (File.Exists(path)) 
            //{
            //    MessageBox.Show("File Already Exist");
            //}
            //else
            //{
            //    File.Create(path);
            //    MessageBox.Show("File Created");
            //}
        }
        FileStream fs;
        BinaryWriter bw;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
           
            try 
            {
                 fs = new FileStream(@"D:\Test\Dept.txt", FileMode.Create, FileAccess.Write);
                 bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtUserID.Text));
                bw.Write(txtName.Text);
                bw.Write(txtLocation.Text);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally 
            {
                fs.Close();
                bw.Close();
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream (@"D:\Test\Dept.txt",FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            try 
            {
                txtUserID.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                fs.Close(); 
                br.Close();
            }
        }
    }
}
