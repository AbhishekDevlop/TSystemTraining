using System;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace T_System_GUI
{
   
    public partial class Product_Form : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Product_Form()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = T_System_Training;Integrated Security = True");
           
        }
        public void Clear() 
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtCompanyName.Clear();
            comboCategory.Items.Clear();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            


            try
            {

                string qry = "insert into Product values(@ProductId,@ProductName,@CompanyName,@ProductPrice,@CatCode)";

                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txtProductId.Text));
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@CatCode", Convert.ToInt32(comboCategory.SelectedValue));


                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully save the record");
                    Clear();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * From Category";
                cmd = new SqlCommand(qry, con);
                con.Open();

                dr = cmd.ExecuteReader();
                DataTable table =new DataTable();
                table.Load(dr);
                comboCategory.DataSource = table;
                comboCategory.DisplayMember = "catName"; // to display
                comboCategory.ValueMember = "catCode";  //for backend
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                cmd = new SqlCommand("Select * from Product where ProductId = @ProductId", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txtProductId.Text));
                
                dr = cmd.ExecuteReader();

                if (dr.HasRows) 
                {
                    if (dr.Read()) 
                    {
                        txtProductId.Text = dr["ProductId"].ToString();
                        txtProductName.Text = dr["ProductName"].ToString();
                        txtCompanyName.Text = dr["CompanyName"].ToString();
                        txtPrice.Text = dr["ProductPrice"].ToString();
                        comboCategory.Text = dr["catCode"].ToString();
                    }

                }
                else 
                {
                    MessageBox.Show("Record Not Found");
                    Clear();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }

            try 
            {
                cmd = new SqlCommand("Select * from Category where Catcode = "+comboCategory.Text.ToString(),con);
                con.Open();
                cmd.Parameters.AddWithValue("@CatCode", Convert.ToInt32(comboCategory.SelectedValue));
                dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                comboCategory.DataSource = table;
                comboCategory.DisplayMember = "catName";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Product set  ProductName=@ProductName,CompanyName=@CompanyName,ProductPrice=@ProductPrice,CatCode=@CatCode where ProductId=@ProductId";

                cmd = new SqlCommand(qry, con);
                con.Open();

                    cmd.Parameters.AddWithValue("@ProductId", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                    cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToDouble(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@CatCode", Convert.ToInt32(comboCategory.SelectedValue));

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Delete from Product where ProductId=@ProductId";

                cmd = new SqlCommand(qry, con);

                con.Open();
                cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txtProductId.Text));
                int result = cmd.ExecuteNonQuery();
                if (result==1)
                {
                    MessageBox.Show("Record Deleted");
                    Clear();
                }
                
              
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }
    }
}
