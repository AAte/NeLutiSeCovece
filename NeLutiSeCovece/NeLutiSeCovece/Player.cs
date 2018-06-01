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
                this.figures[i].Location = new Point(startingPositions[i].X + 12, startingPositions[i].Y + 5);
                figures[i].Height = 55;
                figures[i].Width = 40;
                figures[i].BringToFront();
                figures[i].Visible = true;
                figures[i].FlatAppearance.BorderSize = 0;
            }
        }
    }
}
