using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class SelectXor0
    {
        public void select()
        {
            Console.WriteLine(" Player 1 - Select option 'X' OR 'O' ");
            string S1 = Console.ReadLine();


            if (S1 == "X")
            {
                Console.WriteLine("Player 1 selected 'X'");
                Console.WriteLine("Player 2 selected 'O'");
            }
            else
            {
                Console.WriteLine("Player 1 selected 'O'");
                Console.WriteLine("Player 2 selected 'X'");
            }
        }
    }
}
