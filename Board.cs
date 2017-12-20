using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WoTG
{
    class Board
    {
        private Card[,] unitsOnBoard;
        private Squad[] squadsOnBoard;
        public Board(Headquarter p1HQ, Headquarter p2HQ)
        {
            unitsOnBoard = new Card[3,5];
            squadsOnBoard = new Squad[5];
            unitsOnBoard[2,0] = p1HQ;
            unitsOnBoard[0,4] = p2HQ;
        }
        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; i < 5; j++)
                {
                    if(unitsOnBoard[i,j] != null)
                    {
                        Pen greenPen = new Pen(Color.Green, 1);
                        int x = 100-50*i;
                        int y = 200-50*j;
                        int width = 50;
                        int height = 50;
                        DrawRectangle(blackPen, x, y, width, height);
                    }
                }
            }
        }
    }
}
