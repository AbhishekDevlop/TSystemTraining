using System;
using System.Windows.Forms;

namespace LINQ_TO_Entity_Framework
{
    public partial class Form1 : Form
    {
        EmployeeEntities dbcontext = new EmployeeEntities();
        public Form1()
        {
            InitializeComponent();
        }

        public void Clear() 
        {
            txtSalary.Clear();
            txtName.Clear();
            txtId.Clear();
            txtDesignation.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Designation = txtDesignation.Text;
                emp.Salary = Convert.ToDecimal(txtSalary.Text);

                dbcontext.Employees.Add(emp);
               int result = dbcontext.SaveChanges(); // reflect change to database
                if(result==1)
                {
                    MessageBox.Show("Saved");
                    Clear();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtId.Text));
                if (emp != null)
                {
                    txtName.Text = emp.Name;
                    txtDesignation.Text = emp.Designation;
                    txtSalary.Text = emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    Clear();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtId.Text));
                if (emp != null) // to check whether it is present or not
                {
                    emp.Name = txtName.Text;
                    emp.Designation= txtDesignation.Text;
                    emp.Salary =Convert.ToDecimal( txtSalary.Text);
                    int result = dbcontext.SaveChanges();
                    if(result == 1) 
                    {
                        MessageBox.Show("Record Updated");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    Clear();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtId.Text));
                if (emp != null)
                {
                   dbcontext.Employees.Remove(emp);
                    int result = dbcontext.SaveChanges();
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
