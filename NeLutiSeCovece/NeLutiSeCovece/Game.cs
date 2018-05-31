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
    public partial class Game : Form
    {
        public Game(ArrayList gameSettings)
        {
            InitializeComponent();
        }
         
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
           
            Point[] board = new Point[64];
            Point[] garageRed = new Point[4];
            Point[] garageYellow = new Point[4];
            Point[] garageBlue = new Point[4];
            Point[] garageGreen = new Point[4];

            Pen blackPen = new Pen(Color.Black, 3);                  

            int x = 400, y = 10; //   pocetni koordinati
            for (int i = 0; i < 48; i++)
            {
                // Popolnuvanje na polinjata
                if ((i >= 1 && i <= 5) || (i >= 11 && i <= 12) || (i >= 18 && i <= 22))
                    y += 50 + 5;
                if ((i >= 6 && i <= 10) || (i >= 37 && i <= 41) || (i >= 47))
                    x += 50 + 5;
                if ((i >= 13 && i <= 17) || (i >= 23 && i <= 24) || (i >= 30 && i <= 34))
                    x -= 50 + 5;
                if ((i >= 25 && i <= 29) || (i >= 35 && i <= 36) || (i >= 42 && i <= 46))
                    y -= 50 + 5;

                e.Graphics.DrawEllipse(blackPen, x, y, 50, 50);
                board[i] = new Point(x, y); // zacuvuvane na pozicijata na sekoe pole

                // Obojuvanje na pocetnite polinja i postavuvane na nivnite pocetni pozicii
                if (i == 0)
                {
                    e.Graphics.FillEllipse(Brushes.Red, x, y, 50, 50);
                    board[i] = new Point(x, y);
                }
                else if (i == 12)
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, x, y, 50, 50);
                    board[i] = new Point(x, y);
                }
                else if (i == 24)
                {
                    e.Graphics.FillEllipse(Brushes.Green, x, y, 50, 50);
                    board[i] = new Point(x, y);
                }
                else if (i == 36)
                {
                    e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 50, 50);
                    board[i] = new Point(x, y);
                }
            }
            // base e krajnata lokacijata kaj sto treba da stigne igracot
            // base Red
            y = 65;
            for (int i = 48; i <= 51; i++)
            {
                e.Graphics.FillEllipse(Brushes.Red, x, y, 50, 50);
                board[i] = new Point(x, y);
                y += 55;
            }

            // base Green
            y += 165;
            for (int i = 48; i <= 51; i++)
            {
                e.Graphics.FillEllipse(Brushes.Green, x, y, 50, 50);
                board[i] = new Point(x, y);
                y += 55;
            }

            // base Yellow
            y = 340;
            x = 455;
            for (int i = 52; i <= 55; i++)
            {
                e.Graphics.FillEllipse(Brushes.Yellow, x, y, 50, 50);
                board[i] = new Point(x, y);
                x += 55;
            }

            // base LightBlue
            y = 340;
            x = 235;
            for (int i = 52; i <= 55; i++)
            {
                e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 50, 50);
                board[i] = new Point(x, y);
                x -= 55;
            }
            //Garaza mesto kade sto se smesteni figurite pred da zapocne igrata
            //Garaza Red
            x = 550;
            y = 40;
            e.Graphics.FillEllipse(Brushes.Red, x, y, 65, 65);
            garageRed[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.Red, x, y, 65, 65);
            garageRed[1] = new Point(x, y);
            y += 80;
            garageRed[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Red, x, y, 65, 65);
            x -= 80;
            garageRed[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Red, x, y, 65, 65);

            //Garaza Yellow
            x = 550;
            y = 540;
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);
            garageRed[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);
            garageRed[1] = new Point(x, y);
            y += 80;
            garageRed[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);
            x -= 80;
            garageRed[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);

            //Garaza Green
            x = 50;
            y = 540;
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);
            garageRed[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);
            garageRed[1] = new Point(x, y);
            y += 80;
            garageRed[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);
            x -= 80;
            garageRed[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);

            //Garaza Blue
            x = 50;
            y = 40;
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);
            garageRed[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);
            garageRed[1] = new Point(x, y);
            y += 80;
            garageRed[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);
            x -= 80;
            garageRed[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);

            //Vertinkalna linija
            e.Graphics.DrawLine(blackPen, new Point(800, 0), new Point(800, 780));
            //button1.Location = new Point(board[1].X + 15 , board[1].Y + 5);

        }
        
        Boolean kockaStartFlag = true;
        private void buttonKocka_Click(object sender, EventArgs e)
        {
            if (kockaStartFlag)
            {
                timerKocka.Start();
                kockaStartFlag = false;
            }

            else
            {
                timerKocka.Stop();
                kockaStartFlag = true;
            }  
        }
        //Animirana kocka
        private void timerKocka_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int broj = r.Next(1, 7);
            switch (broj) {
                case 1:
                    buttonKocka.BackgroundImage = NeLutiSeCovece.Properties.Resources.kocka_1;
                    buttonKocka.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    buttonKocka.BackgroundImage = NeLutiSeCovece.Properties.Resources.kocka_2;
                    buttonKocka.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    buttonKocka.BackgroundImage = NeLutiSeCovece.Properties.Resources.kocka_3;
                    buttonKocka.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    buttonKocka.BackgroundImage = NeLutiSeCovece.Properties.Resources.kocka_4;
                    buttonKocka.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 5:
                    buttonKocka.BackgroundImage = NeLutiSeCovece.Properties.Resources.kocka_5;
                    buttonKocka.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 6:
                    buttonKocka.BackgroundImage = NeLutiSeCovece.Properties.Resources.kocka_6;
                    buttonKocka.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }
    }
}
