using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace T_System_GUI
{
    public partial class ProductForm : Form
    {
        SqlConnection con;
        SqlCommandBuilder cmdb;
        DataSet ds;
        SqlDataAdapter adapter;

        public ProductForm()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = T_System_Training;Integrated Security = True");
        }
        public void FillCombo() 
        {

        }

       
    }
}
