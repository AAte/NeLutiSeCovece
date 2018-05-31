using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NeLutiSeCovece
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Proverka za selektirani igraci
        private void cbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRed.Checked == false && cbYellow.Checked == false && cbGreen.Checked == false && cbBlue.Checked == false)
            {
                btnStart.Enabled = false;
            }
            else
                btnStart.Enabled = true;
        }

        private void cbYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRed.Checked == false && cbYellow.Checked == false && cbGreen.Checked == false && cbBlue.Checked == false)
            {
                btnStart.Enabled = false;
            }
            else
                btnStart.Enabled = true;
        }

        private void cbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRed.Checked == false && cbYellow.Checked == false && cbGreen.Checked == false && cbBlue.Checked == false)
            {
                btnStart.Enabled = false;
            }
            else
                btnStart.Enabled = true;
        }

        private void cbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRed.Checked == false && cbYellow.Checked == false && cbGreen.Checked == false && cbBlue.Checked == false)
            {
                btnStart.Enabled = false;
            }
            else
                btnStart.Enabled = true;
        }

        // Prenesuvanje na argumeti za igracite vo glavnata strana
        private void btnStart_Click(object sender, EventArgs e)
        {
            Boolean redChecked = cbRed.Checked;
            Boolean yellowChecked = cbYellow.Checked;
            Boolean greenChecked = cbGreen.Checked;
            Boolean blueChecked = cbBlue.Checked;

            ArrayList gameSettings = new ArrayList();
            gameSettings.Add(redChecked);
            gameSettings.Add(yellowChecked);
            gameSettings.Add(greenChecked);
            gameSettings.Add(blueChecked);

            Form game = new Game(gameSettings);
            this.Hide();
            game.Show();
        }
    }
}
