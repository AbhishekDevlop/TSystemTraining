using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace T_System_GUI
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
           //to establish the connection user interface 
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = T_System_Training;Integrated Security = True");
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
                string qry = "insert into employee values(@Id,@Name,@Designation,@Salary)";

                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id",Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Designation",txtDesignation.Text);
                cmd.Parameters.AddWithValue("@Salary",Convert.ToDouble(txtSalary.Text));

                int result = cmd.ExecuteNonQuery();
                if(result == 1) 
                {
                    MessageBox.Show("Successfully save the record");
                    Clear();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee where Id = @Id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtId.Text = dr["Id"].ToString();
                        txtName.Text = dr["Name"].ToString();
                        txtDesignation.Text = dr["Designation"].ToString();
                        txtSalary.Text = dr["Salary"].ToString();
                    }
                }
                else 
                {
                    MessageBox.Show("Record Not Found");
                    Clear();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Employee set  Name=@Name,Designation=@Designation,Salary=@Salary where Id=@Id"; 

                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtSalary.Text));

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully updated the record");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select Max(Id) from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    txtId.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtId.Text = id.ToString();
                    txtId.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            finally { con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "delete from Employee where Id=@id";

                cmd = new SqlCommand(@qry, con);

                con.Open();

                cmd.Parameters.AddWithValue("Id", Convert.ToInt32(txtId.Text));

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully Deleted the Record");
                    Clear();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);}
            finally { con.Close(); }

        }
    }
}
