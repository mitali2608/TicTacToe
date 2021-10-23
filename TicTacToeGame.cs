using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[] a = new char[ 10 ];
        public void Board()
        {
            for (int i = 1; i < a.Length; i++)
                a[i] = ' ';
            {
                int i = 0;
                Console.WriteLine(a[i]);
            }
        }
    }
}
