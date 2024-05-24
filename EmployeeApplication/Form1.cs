using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(fName.Text, lName.Text, dept.Text, jobTitle.Text);

            double hour = Convert.ToDouble(ratePerHour.Text);
            int totalHour = Convert.ToInt32(totalHoursWorked.Text);
            partTimeEmployee.computeSalary(totalHour, hour);

            firstname.Text = fName.Text;
            lastname.Text = lName.Text;
            salary.Text = Convert.ToString(partTimeEmployee.getSalary());
        }
    }
}
