using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovNaPtici
{
    public partial class EndForm : Form
    {
        string Username;
        private SoundPlayer backgroundMusic;
        public EndForm(string username)
        {
            InitializeComponent();
            Username = username;
            backgroundMusic = new SoundPlayer("EndingMusic.wav");

            label1.Text = "Congratulation " + Username + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundMusic.Stop();
            Form1 nazad = new Form1();
            nazad.StartPosition = FormStartPosition.Manual;
            nazad.Location = this.Location;
            nazad.Show(this);
            Hide();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            backgroundMusic.Play();
        }

        private void EndForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            backgroundMusic.Stop();
        }
    }
}
