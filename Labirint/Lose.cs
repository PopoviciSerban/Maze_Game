using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }

        private void Lose_Load(object sender, EventArgs e)
        {
            label3.Text = Global.Score.ToString();

            if (Global.Score > Global.HighScore)
                Global.HighScore = Global.Score;

            label4.Text = Global.HighScore.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.Score = 0;

            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
