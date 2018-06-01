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
using System.Threading;

namespace NeLutiSeCovece
{
    public partial class Game : Form
    {   
        public static ArrayList gameSettings;

        Player playerRed, playerYellow, playerGreen, playerBlue;
        Player[] playersObjects =new Player[4];

        Point[] board = new Point[64];
        Point[] garageRed = new Point[4];
        Point[] garageYellow = new Point[4];
        Point[] garageBlue = new Point[4];
        Point[] garageGreen = new Point[4];

        Pen blackPen = new Pen(Color.Black, 3);
        int turnCounter = 0;
        bool doubleTurn = false;
        int kocka;

        int[] playerRedpath = new int[52] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 
                                         26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };

        int[] playerYellowpath = new int[52] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 
                                         36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 56, 57, 58, 59 };

        int[] playerGreenpath = new int[52] { 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 
                                         0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 52, 53, 54, 55 };

        int[] playerBluepath = new int[52] { 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 
                                         14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 60, 61, 62, 63 };
       
        public Game(ArrayList gameSettingsMenu)
        {
            InitializeComponent();
            gameSettings = gameSettingsMenu;
        }

        public bool entryFlag = true;

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            //Crtane na mapata i postavuvavena na koordinati za patekata
            drawMap(e);

            //Vertinkalna linija
            e.Graphics.DrawLine(blackPen, new Point(800, 0), new Point(800, 780));

            //Pecatene koj igrac e na red
            turnText();

            if (entryFlag)
            {
                // Polnenje na garazhite vo odnos na izbranite igraci (checkbox-ovite) od menito
            if (Convert.ToBoolean(gameSettings[0]))
                fillGarageRed();

            if (Convert.ToBoolean(gameSettings[1]))
                fillGarageYellow();

            if (Convert.ToBoolean(gameSettings[2]))
                fillGarageGreen();

            if (Convert.ToBoolean(gameSettings[3]))
                fillGarageBlue();
            }

            entryFlag = false;
        }

        public void turnText()
        {

            switch (turnCounter)
            {
                case 0:
                    lbTurn.Text = "Red turn";
                    lbTurn.ForeColor = Color.Red;
                    break;
                case 1:
                    lbTurn.Text = "Yellow turn";
                    lbTurn.ForeColor = Color.Yellow;
                    break;
                case 2:
                    lbTurn.Text = "Green turn";
                    lbTurn.ForeColor = Color.Green;
                    break;
                case 3:
                    lbTurn.Text = "Blue turn";
                    lbTurn.ForeColor = Color.DodgerBlue;
                    break;

            }

        }

        public void drawMap(PaintEventArgs e)
        {
            int x = 400, y = 10;            //pocetni koordinati

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
                board[i] = new Point(x, y);             // zacuvuvanje na pozicijata na sekoe pole

                // Obojuvanje na pocetnite polinja i postavuvanje na nivnite pocetni pozicii
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
            y += 330;
            for (int i = 52; i <= 55; i++)
            {
                e.Graphics.FillEllipse(Brushes.Green, x, y, 50, 50);
                board[i] = new Point(x, y);
                y -= 55;
            }

            // base Yellow
            y = 340;
            x = 620;
            for (int i = 56; i <= 59; i++)
            {
                e.Graphics.FillEllipse(Brushes.Yellow, x, y, 50, 50);
                board[i] = new Point(x, y);
                x -= 55;
            }

            // base Blue
            y = 340;
            x = 70;
            for (int i = 60; i <= 63; i++)
            {
                e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 50, 50);
                board[i] = new Point(x, y);
                x += 55;
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
            garageYellow[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);
            garageYellow[1] = new Point(x, y);
            y += 80;
            garageYellow[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);
            x -= 80;
            garageYellow[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Yellow, x, y, 65, 65);

            //Garaza Green
            x = 50;
            y = 540;
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);
            garageGreen[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);
            garageGreen[1] = new Point(x, y);
            y += 80;
            garageGreen[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);
            x -= 80;
            garageGreen[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.Green, x, y, 65, 65);

            //Garaza Blue
            x = 50;
            y = 40;
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);
            garageBlue[0] = new Point(x, y);
            x += 80;
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);
            garageBlue[1] = new Point(x, y);
            y += 80;
            garageBlue[2] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);
            x -= 80;
            garageBlue[3] = new Point(x, y);
            e.Graphics.FillEllipse(Brushes.DodgerBlue, x, y, 65, 65);

        }

        // Funkcija za kreiranje igraci i polnenje na garazite
        public void fillGarageRed()
        {
            Button[] btnRed = new Button[4];
            btnRed[0] = btnRed0;
            btnRed[1] = btnRed1;
            btnRed[2] = btnRed2;
            btnRed[3] = btnRed3;
            playerRed = new Player(btnRed,playerRedpath,board,garageRed);
            playerRed.setStartingPosition();
            playersObjects[0] = playerRed;
        }

        public void fillGarageYellow()
        {
            Button[] btnYellow = new Button[4];
            btnYellow[0] = btnYellow0;
            btnYellow[1] = btnYellow1;
            btnYellow[2] = btnYellow2;
            btnYellow[3] = btnYellow3;
            playerYellow = new Player(btnYellow,playerYellowpath,board,garageYellow);
            playerYellow.setStartingPosition();
            playersObjects[1] = playerYellow;

        }

        public void fillGarageGreen()
        {
            Button[] btnGreen = new Button[4];
            btnGreen[0] = btnGreen0;
            btnGreen[1] = btnGreen1;
            btnGreen[2] = btnGreen2;
            btnGreen[3] = btnGreen3;
            playerGreen = new Player(btnGreen,playerGreenpath,board,garageGreen);
            playerGreen.setStartingPosition();
            playersObjects[2] = playerGreen;
        }

        public void fillGarageBlue()
        {
            Button[] btnBlue = new Button[4];
            btnBlue[0] = btnBlue0;
            btnBlue[1] = btnBlue1;
            btnBlue[2] = btnBlue2;
            btnBlue[3] = btnBlue3;
            playerBlue = new Player(btnBlue,playerBluepath,board,garageBlue);
            playerBlue.setStartingPosition();
            playersObjects[3] = playerBlue;
        }

        Boolean kockaStartFlag = true;
        
        // Nastani za pridvizuvanje na kopcinjata
        // Red
        private void btnRed0_Click(object sender, EventArgs e)
        {
            if(playerRed.moveFigure(kocka, 0))
            {
                kickingPlayer(playerRed, 0);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerRed.CheckValidMoves(kocka, 0))
            {
                btnNextTurn.Enabled = true;
            }
        }
        
        private void btnRed1_Click(object sender, EventArgs e)
        {
            if (playerRed.moveFigure(kocka, 1))
            {
                kickingPlayer(playerRed, 1);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerRed.CheckValidMoves(kocka, 1))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnRed2_Click(object sender, EventArgs e)
        {
            if (playerRed.moveFigure(kocka, 2))
            {
                kickingPlayer(playerRed, 2);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerRed.CheckValidMoves(kocka, 2))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnRed3_Click(object sender, EventArgs e)
        {
            if (playerRed.moveFigure(kocka, 3))
            {
                kickingPlayer(playerRed, 3);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerRed.CheckValidMoves(kocka, 3))
            {
                btnNextTurn.Enabled = true;
            }
        }

        // Yellow
        private void btnYellow0_Click(object sender, EventArgs e)
        {
            if (playerYellow.moveFigure(kocka, 0))
            {
                kickingPlayer(playerYellow, 0);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerYellow.CheckValidMoves(kocka, 0))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnYellow1_Click(object sender, EventArgs e)
        {
            if (playerYellow.moveFigure(kocka, 1))
            {
                kickingPlayer(playerYellow, 1);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerYellow.CheckValidMoves(kocka, 1))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnYellow2_Click(object sender, EventArgs e)
        {
            if (playerYellow.moveFigure(kocka, 2))
            {
                kickingPlayer(playerYellow, 2);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerYellow.CheckValidMoves(kocka, 2))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnYellow3_Click(object sender, EventArgs e)
        {
            if (playerYellow.moveFigure(kocka, 3))
            {
                kickingPlayer(playerYellow, 3);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerYellow.CheckValidMoves(kocka, 3))
            {
                btnNextTurn.Enabled = true;
            }
        }

        // Green
        private void btnGreen0_Click(object sender, EventArgs e)
        {
            if (playerGreen.moveFigure(kocka, 0))
            {
                kickingPlayer(playerGreen, 0);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerGreen.CheckValidMoves(kocka, 0))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnGreen1_Click(object sender, EventArgs e)
        {
            if (playerGreen.moveFigure(kocka, 1))
            {
                kickingPlayer(playerGreen, 1);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerGreen.CheckValidMoves(kocka, 1))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnGreen2_Click(object sender, EventArgs e)
        {
            if (playerGreen.moveFigure(kocka, 2))
            {
                kickingPlayer(playerGreen, 2);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerGreen.CheckValidMoves(kocka, 2))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnGreen3_Click(object sender, EventArgs e)
        {
            if (playerGreen.moveFigure(kocka, 3))
            {
                kickingPlayer(playerGreen, 3);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerGreen.CheckValidMoves(kocka, 3))
            {
                btnNextTurn.Enabled = true;
            }
        }

        // Blue
        private void btnBlue0_Click(object sender, EventArgs e)
        {
            if (playerBlue.moveFigure(kocka, 0))
            {
                kickingPlayer(playerBlue, 0);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerBlue.CheckValidMoves(kocka, 0))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnBlue1_Click(object sender, EventArgs e)
        {
            if (playerBlue.moveFigure(kocka, 1))
            {
                kickingPlayer(playerBlue, 1);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerBlue.CheckValidMoves(kocka, 1))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnBlue2_Click(object sender, EventArgs e)
        {
            if (playerBlue.moveFigure(kocka, 2))
            {
                kickingPlayer(playerBlue, 2);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerBlue.CheckValidMoves(kocka, 2))
            {
                btnNextTurn.Enabled = true;
            }
        }

        private void btnBlue3_Click(object sender, EventArgs e)
        {
            if (playerBlue.moveFigure(kocka, 3))
            {
                kickingPlayer(playerBlue, 3);
                kocka = 0;
                btnNextTurn.Enabled = true;
            }
            if (!playerBlue.CheckValidMoves(kocka, 3))
            {
                btnNextTurn.Enabled = true;
            }
        }

        // Funkcija koja proveruva dali ima drug igrac na istata pozicija za da se vrati vo garazata
        private void kickingPlayer(Player kickerObj, int figNumber)
        {
            for (int i = 0; i < 4; i++)
            {
                // proverka dali se raboti za istiot igrac
                if (playersObjects[i] != null && kickerObj.Equals(playersObjects[i]))
                {
                    continue;
                }

                // dokolku se raboti za razlicen igrac
                if (playersObjects[i] != null && kickerObj.returnPosition(figNumber) == playersObjects[i].returnPosition(0))
                {
                    playersObjects[i].returnToGarage(0);
                    break;
                }
                if (playersObjects[i] != null && kickerObj.returnPosition(figNumber) == playersObjects[i].returnPosition(1))
                {
                    playersObjects[i].returnToGarage(1);
                    break;
                }
                if (playersObjects[i] != null && kickerObj.returnPosition(figNumber) == playersObjects[i].returnPosition(2))
                {
                    playersObjects[i].returnToGarage(2);
                    break;
                }
                if (playersObjects[i] != null && kickerObj.returnPosition(figNumber) == playersObjects[i].returnPosition(3))
                {
                    playersObjects[i].returnToGarage(3);
                    break;
                }
            }
        }

        // Nastan pri klik na kocka
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
                buttonKocka.Enabled = false;

                if (playersObjects[turnCounter] != null)
                {
                    playersObjects[turnCounter].figures[0].Enabled = true;
                    playersObjects[turnCounter].figures[1].Enabled = true;
                    playersObjects[turnCounter].figures[2].Enabled = true;
                    playersObjects[turnCounter].figures[3].Enabled = true;
                }

                if (kocka == 6)
                {
                    doubleTurn=true;
                }

                if (checkMoves(playersObjects[turnCounter]))
                { 
                    btnNextTurn.Enabled = false;
                }
                else if (kocka == 6 && checkAnyInactive(playersObjects[turnCounter]))
                {
                    btnNextTurn.Enabled = false;
                }
                else
                {
                    btnNextTurn.Enabled = true;
                }

                  
            }  
        }

        //Nastan pri klik na kopceto za next turn
        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            if (!doubleTurn) { 
                if (playersObjects[turnCounter] != null)
                {
                    playersObjects[turnCounter].figures[0].Enabled = false;
                    playersObjects[turnCounter].figures[1].Enabled = false;
                    playersObjects[turnCounter].figures[2].Enabled = false;
                    playersObjects[turnCounter].figures[3].Enabled = false;
                }

                turnCounter++;

                if (turnCounter >= 4)
                {
                    turnCounter = 0;
                }

                while (playersObjects[turnCounter] == null) {
                    turnCounter++;
                    if (turnCounter >= 4)
                    {
                        turnCounter = 0;
                    }
                }

               
            }
            doubleTurn = false;
            buttonKocka.Enabled = true;
            btnNextTurn.Enabled = false;
        }

        // Proverka dali postoi nekoj igrac na mapata
        private Boolean checkAnyInactive(Player p)
        {
            for (int i = 0; i < 4; i++)
            {
                if (p.active[i] ==false)
                {
                    return true;
                }
            }
            return false;
        }
        private Boolean checkMoves(Player p)
        {
            for (int i = 0; i < 4; i++)
            {
                if (p.CheckValidMoves(kocka, i) == true)
                {
                    return true;
                }
            }
            return false;
        }

        //Animirana kocka
        private void timerKocka_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int broj = r.Next(1, 7);
            kocka = broj;
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

        //Gasenje
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
    
}
