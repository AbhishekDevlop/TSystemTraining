using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace T_System_GUI
{
    public partial class AdO : Form
    {
        SqlConnection con;
        SqlCommandBuilder cmdb;
        DataSet ds;
        SqlDataAdapter adapter;
        public AdO()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = T_System_Training;Integrated Security = True");

        }

        public DataSet GetAllEmployee() 
        {
            adapter = new SqlDataAdapter("select * from Employee", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds,"Emp");
            return ds;

        }
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear() 
        {
            txtId.Clear();
            txtName.Clear();
            txtDesignation.Clear();
            txtSalary.Clear();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { 
                ds = GetAllEmployee();
                DataRow row = ds.Tables["Emp"].NewRow();//to create new row
                row["Id"] = txtId.Text;
                row["Name"] = txtName.Text;
                row["Designation"] = txtDesignation.Text;
                row["Salary"] = txtSalary.Text;

                ds.Tables["Emp"].Rows.Add(row);// to add new row to database table 
               
                int result = adapter.Update(ds.Tables["Emp"]);// to change reflect into the database
             
                if (result == 1)
                {
                    MessageBox.Show("Inserted");//to display massage
                    Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployee();
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Designation"] = txtDesignation.Text;
                    row["Salary"] = Convert.ToDecimal(txtSalary.Text);

                    int result = adapter.Update(ds.Tables["Emp"]);// to change reflect into the database
                    if (result == 1)
                    {
                        MessageBox.Show("Record Updated");
                        Clear();
                    }
                }
                else { MessageBox.Show("Record Not Found"); Clear(); }

            }catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployee();
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text)); // to find the record 
                if (row != null)// to check record is there
                {
                    txtName.Text = row["Name"].ToString();
                    txtDesignation.Text = row["Designation"].ToString();
                    txtSalary.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not found"); //display massage to user
                    Clear();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployee();
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text)); // to find the record 

                if (row != null) // to check record is there
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["Emp"]); // to change reflect into the database
                    if(result == 1) 
                    {
                        MessageBox.Show("Record Deleted"); //display massage to user
                        Clear();
                    }
                }
                else { MessageBox.Show("Record Not Found"); Clear(); } //if record not in database
            }catch (Exception ex) { MessageBox.Show(ex.Message);}

        }
    }
}

