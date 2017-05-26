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
    
    public partial class Form1 : Form
    {
        FormUser formUser = new FormUser();

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            formUser.Show();
            
         }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            this.Hide();
            instructions.Show();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            FormHighScores highscores = new FormHighScores();
            this.Hide();
            highscores.Show();
        }
    }
    }

