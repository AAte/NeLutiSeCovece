﻿using System;
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

        public Button[] figures { get; set; }
        public int[] pathBoard { get; set; }
        public int[] positionBoard { get; set; }
        public Boolean[] active { get; set; }
        Point[] board { get; set; }
       

        public Player(Button[] figures, int[]path, Point[] board)
        {
            this.active = new Boolean[4];
            this.figures = new Button[4];
            this.positionBoard = new int[4];
            for(int i = 0; i < 4; i++)
            {
                this.figures[i] = figures[i];
                positionBoard[i] = 0;
                active[i] = false;
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
        
        //Funkcija za pridvizuvane na pionite
        public bool moveFigure(int kocka,int figureNum) {
            if (kocka == 6 && active[figureNum] == false)
            {
                active[figureNum] = true;
                figures[figureNum].Location = board[pathBoard[0]];
                return true;
            }
            else if (active[figureNum])
            {
                if (positionBoard[figureNum] + kocka <= 51)
                {
                    positionBoard[figureNum] += kocka;
                    figures[figureNum].Location = board[pathBoard[positionBoard[figureNum]]];
                    return true;
                }
                
            }
            return false;
            
        }
    }
}
