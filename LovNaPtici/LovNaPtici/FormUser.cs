using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovNaPtici
{
    public partial class FormUser : Form
    {
      
        
        public FormUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            Form2 form2 = new Form2(username);
            this.Hide();
            form2.Show();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;

        }

        private void tbUsername_Validated(object sender, EventArgs e)
        {
           
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                e.Cancel = true;
                error.SetError(tbUsername, "Please enter your username!");
                lblError.Text = "Please enter your username!";
            }
            else
            {
                error.SetError(tbUsername, "");
                lblError.Text = "";
            }
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
