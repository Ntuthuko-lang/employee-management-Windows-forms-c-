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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string User = "Admin";
            string pass = "HR123";

            if(User == txtUser.Text && pass == password.Text)
            {
                MessageBox.Show("Access granted", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SplashScreen sp = new SplashScreen();
                sp.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
