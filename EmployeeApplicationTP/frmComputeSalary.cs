using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplicationTP
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            bool condition = string.IsNullOrWhiteSpace(firstnamebox.Text) && string.IsNullOrWhiteSpace(lastnamebox.Text) && string.IsNullOrWhiteSpace(jobtitlebox.Text) && string.IsNullOrWhiteSpace(departmentbox.Text) && string.IsNullOrWhiteSpace(ratebox.Text) && string.IsNullOrWhiteSpace(totalbox.Text);
            if (condition) { 
            MessageBox.Show("Please fill in all of the text fields");
                return;
            }
            else
            {
                PartTimeEmployee employee = new PartTimeEmployee(firstnamebox.Text, lastnamebox.Text, departmentbox.Text, jobtitlebox.Text);
                employee.computeSalary(int.Parse(totalbox.Text), double.Parse(ratebox.Text));
                employee.getSalary();

                fnlbl.Text = "First name: "+employee.FirstName;
                lnlbl.Text = "Last name: " + employee.LastName;
                bslbl.Text = "Basic Salary: " + employee.BasicSalary;
            }


        }
    }
}
