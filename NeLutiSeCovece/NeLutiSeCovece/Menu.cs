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
        private void cbCheck() {
            if (cbRed.Checked == false && cbYellow.Checked == false && cbGreen.Checked == false && cbBlue.Checked == false)
            {
                btnStart.Enabled = false;
            }
            else
                btnStart.Enabled = true;
        }
        // Proverka za selektirani igraci
        private void cbRed_CheckedChanged(object sender, EventArgs e)
        {
            cbCheck();
        }

        private void cbYellow_CheckedChanged(object sender, EventArgs e)
        {
            cbCheck();
        }

        private void cbGreen_CheckedChanged(object sender, EventArgs e)
        {
            cbCheck();
        }

        private void cbBlue_CheckedChanged(object sender, EventArgs e)
        {
            cbCheck();
        }

        // Prenesuvanje na argumeti za igracite vo glavnata strana
        private void btnStart_Click(object sender, EventArgs e)
        {
            ArrayList gameSettings = new ArrayList();
            gameSettings.Add(cbRed.Checked);
            gameSettings.Add(cbYellow.Checked);
            gameSettings.Add(cbGreen.Checked);
            gameSettings.Add(cbBlue.Checked);

            Form game = new Game(gameSettings);
            this.Hide();
            game.Show();
        }
    }
}
