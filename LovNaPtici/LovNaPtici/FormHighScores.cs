using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovNaPtici
{
    public partial class FormHighScores : Form
    {
        public FormHighScores()
        {
            InitializeComponent();
            string fileName = "Highscores.txt";
            string fpath = Path.GetFullPath(fileName);

            string[] lines = System.IO.File.ReadAllLines(fpath);
           
          

            var orderedScores = lines.OrderByDescending(x => int.Parse(x.Split('-')[1]));
            foreach (var score in orderedScores)
            {
                lbHighScores.Items.Add(score.ToString());
            }

           

           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            forma1.StartPosition = FormStartPosition.Manual;
            forma1.Location = this.Location;
            forma1.Show(this);
            Hide();
        }

        private void FormHighScores_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

       
    }
}
