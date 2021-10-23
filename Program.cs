using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe game :");
            TicTacToeGame t = new TicTacToeGame();
            t.Board();
        }
    }
}
