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
            int c = 0;
            comboRed.SelectedIndex = 0;
            comboYellow.SelectedIndex = 0;
            comboGreen.SelectedIndex = 0;
            comboBlue.SelectedIndex = 0;
            if (cbRed.Checked == true)
            {
                c++;
                comboRed.Enabled = true;
                comboRed.Visible = true;
            }
            else
            {
                comboRed.Enabled = false;
                comboRed.Visible = false;
            }

            if (cbYellow.Checked == true)
            {
                c++;
                comboYellow.Enabled = true;
                comboYellow.Visible = true;
            }
            else
            {
                comboYellow.Enabled = false;
                comboYellow.Visible = false;
            }

            if (cbGreen.Checked == true)
            {
                c++;
                comboGreen.Enabled = true;
                comboGreen.Visible = true;
            }
            else
            {
                comboGreen.Enabled = false;
                comboGreen.Visible = false;
            }

            if (cbBlue.Checked == true)
            {
                c++;
                comboBlue.Enabled = true;
                comboBlue.Visible = true;
            }
            else
            {
                comboBlue.Enabled = false;
                comboBlue.Visible = false;
            }

            if (c == 0||c==1)
            {
                btnStart.Enabled = false;
            }
            else if (c >= 2)
            {
                btnStart.Enabled = true;
            }
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

            Boolean[] bots = new Boolean[4];
            settingBots(bots);
            Form game = new Game(gameSettings,bots);
            this.Hide();
            game.Show();
        }

        private void settingBots(Boolean[] bots) {

            if (comboRed.SelectedItem == "Computer")
            {
                bots[0] = true;
            }
            else
            {
                bots[0] = false;
            }

            if (comboYellow.SelectedItem == "Computer")
            {
                bots[1] = true;
            }
            else
            {
                bots[1] = false;
            }

            if (comboGreen.SelectedItem == "Computer")
            {
                bots[2] = true;
            }
            else
            {
                bots[2] = false;
            }
            
            if (comboBlue.SelectedItem == "Computer")
            {
                bots[3] = true;
            }
            else
            {
                bots[3] = false;
            }
        }

    }
}
