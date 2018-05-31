using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeLutiSeCovece
{
    class Player
    {
        public Button[] figures;
        
        public Player(Button[] figures)
        {
            this.figures = new Button[4];
            for(int i = 0; i < 4; i++)
            {
                this.figures[i] = figures[i];
            }
        }

        public void setStartingPosition(Point[] startingPositions, String boja)
        {
            for (int i = 0; i < 4; i++) {
                this.figures[i].Location = new Point(startingPositions[i].X + 18, startingPositions[i].Y + 8);
                figures[i].Height = 50;
                figures[i].Width = 30;
                figures[i].BringToFront();
                figures[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                figures[i].FlatAppearance.BorderSize = 0;
                figures[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                figures[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                figures[i].BackColor = Color.Transparent;

                switch (boja)
                {
                    case "red":
                        figures[i].BackgroundImage = NeLutiSeCovece.Properties.Resources.pion_red;
                        figures[i].BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case "yellow":
                        figures[i].BackgroundImage = NeLutiSeCovece.Properties.Resources.pion_yellow;
                        figures[i].BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case "green":
                        figures[i].BackgroundImage = NeLutiSeCovece.Properties.Resources.pion_green;
                        figures[i].BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case "blue":
                        figures[i].BackgroundImage = NeLutiSeCovece.Properties.Resources.pion_blue;
                        figures[i].BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                }
                
            }
        }
    }
}
