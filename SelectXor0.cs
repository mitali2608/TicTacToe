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
                Console.WriteLine("Player selected 'X'");
                Console.WriteLine("Computer selected 'O'");
            }
            else
            {
                Console.WriteLine("Player selected 'O'");
                Console.WriteLine("Computer selected 'X'");
            }

            if (S2 == "0")
            {
                Console.WriteLine("Player selected 'O'");
                Console.WriteLine("Computer selected 'X'");
            }
            else
            {
                Console.WriteLine("Player selected 'X'");
                Console.WriteLine("Computer selected 'O'");
            }
        }
    }
}
