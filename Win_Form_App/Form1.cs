using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUId.Text =="Abhishek"&&textPass.Text == "admin") 
            {
                MessageBox.Show("Welcome");
            }
            else
                MessageBox.Show("Fail to Log In");
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtUId.Clear();
            textPass.Clear();
           
        }
    }
}
