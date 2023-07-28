using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Tic_Toc_Toe
{
    class TicTacToe
    {

        //public Player PlayerX; public Player PlayerO;
        public TicTacToe()
        {
            play();
        }
        //Luot choi
        public void play()
        {


            int n=-1;
            do
            {
                Console.WriteLine("1.Player vs Player");
                Console.WriteLine("2.Player vs Robot");
                Console.WriteLine("3.Robot vs Robot");
                Console.WriteLine("Nhap lua chon: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 3);
            int moveCounter = 0;
            Board gameBoard = new Board();
            if (n == 1) { 
                Player playerX = new Player('X');
                Player playerO = new Player('O');
                Player currentPlayer = playerX;

                bool play = true;
                while (play)
                {
                    gameBoard.printBoard();
                    Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                    try
                    {
                        int turn = (moveCounter % 2 == 0) ? playerX.takeTurn() : playerO.takeTurn();

                        gameBoard.putMark(currentPlayer, turn);
                        gameBoard.clearBoard();
                        moveCounter++;
                       // playerO.removeIndexByValue(turn);

                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                            gameBoard.printBoard();
                            play = false;
                        }
                        else if (checkDraw(moveCounter))
                        {
                            Console.WriteLine("DRAW");
                            gameBoard.printBoard();
                            play = false;
                        }
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            else if(n==2)
            {
                Player playerX = new Player('X');
                Robot playerO = new Robot('O');
                Player currentPlayer = playerX;

                bool play = true;
                while (play)
                {
                    gameBoard.printBoard();
                    if (currentPlayer == playerX)
                    {
                        Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());
                    }
                    try
                    {
                        int turn = (moveCounter % 2 == 0) ? playerX.takeTurn() : playerO.takeTurn();
                        if (currentPlayer == playerO)
                        {
                            Thread.Sleep(2000);
                        }
                        gameBoard.putMark(currentPlayer, turn);
                        gameBoard.clearBoard();
                        moveCounter++;
                        playerO.removeIndexByValue(turn);

                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                            gameBoard.printBoard();
                            play = false;
                        }
                        else if (checkDraw(moveCounter))
                        {
                            Console.WriteLine("DRAW");
                            gameBoard.printBoard();
                            play = false;
                        }
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Robot playerX = new Robot('X');
                Robot playerO = new Robot('O');
                Player currentPlayer = playerX;

                bool play = true;
                while (play)
                {
                    gameBoard.printBoard();
                   // Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                    try
                    {
                        int turn = (moveCounter % 2 == 0) ? playerX.takeTurn() : playerO.takeTurn();
                        Thread.Sleep(1500);
                        gameBoard.putMark(currentPlayer, turn);
                        gameBoard.clearBoard();
                        moveCounter++;
                        playerX.removeIndexByValue(turn);
                        playerO.removeIndexByValue(turn);

                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                            gameBoard.printBoard();
                            play = false;
                        }
                        else if (checkDraw(moveCounter))
                        {
                            Console.WriteLine("DRAW");
                            gameBoard.printBoard();
                            play = false;
                        }
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;

                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }

        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }
    }
}