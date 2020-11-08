using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomayin
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            hours_tbt.Visible = false;
            hours_lbl.Visible = false;
            label2.Visible = false;
           

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(salary_tbt.Text);
            double hours = Convert.ToDouble(hours_tbt.Text);
            double gross = 0.0;
            double overtime = 0.0;
            double tax = 0.0;


            if (overtime_btn.Checked)
            {
                overtime = salary * (hours - 40)* 0.5;
                gross = salary * hours + overtime;
            }
            else
            {
                gross = salary * hours;
            }
            
            tax = gross * 0.2;
            double netsalary = gross - tax;
            display_lbl.Text = gross.ToString();
            MessageBox.Show("Gross income : R "+ gross.ToString()  +"\n"+ "Tax : R "+" " + tax + "\n" + "Net Salary : R" + " " + netsalary, "PaySlip", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void overtime_btn_CheckedChanged(object sender, EventArgs e)
        {
            hours_tbt.Visible = true;
            hours_lbl.Visible = true;
            label2.Visible = true;
        }
   

        private void normal_btn_CheckedChanged(object sender, EventArgs e)
        {
            hours_tbt.Visible = true;
            hours_lbl.Visible = true;
            label2.Visible = false;
        }

        private void Name_tbt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
