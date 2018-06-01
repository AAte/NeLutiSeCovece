using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeLutiSeCovece
{
    class Player : UserControl
    {

        public Button[] figures { get; set; }           // vkupno 4 figuri
        public int[] pathBoard { get; set; }            // vkupno 52 polinja - patekata po koja se dvizi sekoj igrac poedinecno - 48 zaednicki polinja + 4 polinja od bazata
        public int[] positionBoard { get; set; }        // niza od 4 polina koja gi cuva poziciite na sekoja figura vo pathBoard
        public Boolean[] active { get; set; }           // niza od 4 polina koja pokazuva koja figura e izlezena od garazata
        Point[] board { get; set; }                     // vkupno 64 polinja --- site polinja na mapata
        Point[] garages { get; set; }                   // vkupno 4 garazi za sekoj igrac

        public Player(Button[] figures, int[]path, Point[] board, Point[] garages)
        {
            
            this.active = new Boolean[4];
            this.figures = new Button[4];
            this.positionBoard = new int[4];
            this.garages = new Point[4];

            for (int i = 0; i < 4; i++)
            {
                this.figures[i] = figures[i];
                positionBoard[i] = 0;
                active[i] = false;
                this.garages[i] = garages[i];
            }

            this.pathBoard = new int[52];
            for (int i = 0; i < 52; i++) {
                this.pathBoard[i] = path[i];
            }

            this.board = new Point[64];
            for (int i = 0; i < 64; i++)
            {
                this.board[i] = board[i];
            }
        }

        // Funkcija za stavanje na pionite vo garaza
        public void setStartingPosition()
        {
            for (int i = 0; i < 4; i++) {
                this.figures[i].Location = new Point(garages[i].X + 15, garages[i].Y + 11);
                figures[i].Height = 45;
                figures[i].Width = 35;
                figures[i].BringToFront();
                figures[i].Visible = true;
                figures[i].FlatAppearance.BorderSize = 0;
                figures[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                figures[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                figures[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
        }
        
        //Funkcija za pridvizuvanje na pionite
        public bool moveFigure(int kocka, int figureNum) {
            if (kocka == 6 && active[figureNum] == false && !startTaken(figureNum))
            {
                active[figureNum] = true;
                figures[figureNum].Location = new Point(board[pathBoard[0]].X + 8, board[pathBoard[0]].Y + 4);
                return true;
            }
            else if (active[figureNum])
            {
                if (positionBoard[figureNum] + kocka <= 51 && !figuresOverlap(kocka, figureNum))
                {
                    positionBoard[figureNum] += kocka;
                    figures[figureNum].Location = new Point(board[pathBoard[positionBoard[figureNum]]].X + 8, board[pathBoard[positionBoard[figureNum]]].Y + 4);
                    return true;
                }  
            }
            return false;
        }

        // Proverka dali ima slobodni potezi (za next player kopceto)
        public bool CheckValidMoves(int kocka, int figureNum)
        {
            if (kocka == 6 && active[figureNum] == false && !startTaken(figureNum))
            {
                return true;
            }
            else if (active[figureNum])
            {
                if (positionBoard[figureNum] + kocka <= 51 && !figuresOverlap(kocka, figureNum))
                {
                    return true;
                }
            }
            return false;
        }

        // Funkcija sto ne dozvoluva dva piona so ista boja da se naogaat zaedno na startot
        private bool startTaken(int figureNum)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == figureNum)
                    continue;

                if (positionBoard[i]==0 && active[i])
                {
                    return true;
                }
            }
            return false;
        }

        // Funkcija sto ne dozvoluva dva piona so ista boja da se naogaat zaedno
        private bool figuresOverlap(int kocka,int figureNum)
        {
            for(int i = 0; i < 4; i++)
            {
                if (i == figureNum)
                    continue;

                if (positionBoard[figureNum] + kocka == positionBoard[i]) {
                    return true;
                }
            }
            return false;
        }

        //Funkcija za zemanje na pozicijata na pionot
        public int returnPosition(int p)
        {
           return this.pathBoard[positionBoard[p]];
        }

        // Funkcija za vrakjanje na protivnickiot pion vo garaza
        public void returnToGarage(int figureNum)
        {
            this.figures[figureNum].Location = new Point(garages[figureNum].X + 15, garages[figureNum].Y + 11);
            this.active[figureNum] = false;
            this.positionBoard[figureNum] = 0;
        }
    }
}
