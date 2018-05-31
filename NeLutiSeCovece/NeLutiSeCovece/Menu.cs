﻿using System;
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

        // 
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
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool redChecked = cbRed.Checked;
            bool yellowChecked = cbYellow.Checked;
            bool greenChecked = cbGreen.Checked;
            bool blueChecked = cbBlue.Checked;

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
