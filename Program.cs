using System;

namespace WorkshopTicTacProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame tttg = new TicTacToeGame();
            tttg.DrawBoard();
            char UISymbol = tttg.GetUserInputType();
        }
    }
}
