using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTicTacProgram
{
    class TicTacToeGame
    {
        char[] Gamegrid = new char[10];
        public char[] DrawBoard()
        {
            for(int i = 1; i < 10; i++)
            {
                Gamegrid[i] = ' ';
            }
            return Gamegrid;
        }
        public char GetUserInputType()
        {
            Console.WriteLine("Enter the symbol for user : ");
            string v = Console.ReadLine().ToUpper();
            char UserInput = v[0];
            Console.WriteLine("The user input type is " + UserInput);
            return UserInput;
        }
    }
}
