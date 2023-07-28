using Game_Tic_Toc_Toe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tic_Toc_Toe
{
    
    class Program
    {
        static void Main(string[] args)
        {

            TicTacToe game = new TicTacToe();
            game.play();
            Console.ReadKey();
        }
    }
}