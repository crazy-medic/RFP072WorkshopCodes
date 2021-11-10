using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTicTacProgram
{
    class TicTacToeGame
    {
        char[] Gamegrid = new char[10];
        const char V = ' ';

        public void DrawBoard()
        {
            for(int i = 1; i < 10; i++)
            {
                Gamegrid[i] = V;
            }
        }
    }
}
