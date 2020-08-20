using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            string whoseTurnItIs = "X";
            int locationNumber = 1;
            string[,] array2D = new string[3, 3];
            int count = 1;
            bool resetGame = false;


            for (int i = 0; i <= array2D.Rank; i++)
            {
                for (int j = 0; j <= array2D.Rank; j++)
                {
                    array2D[i, j] =  locationNumber.ToString();
                    locationNumber++;
                }
            }

            while (!resetGame)
            {
                for (int i = 0; i <= array2D.Rank; i++)
                {
                    for (int j = 0; j <= array2D.Rank; j++)
                    {
                        Console.Write(" " + (array2D[i, j]) + " ||");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }

                Console.WriteLine("Player {0} ", whoseTurnItIs + " Choose your field");
                string locatiopnNumberString = Console.ReadLine();
                if(int.TryParse(locatiopnNumberString , out locationNumber))
                {
                    for (int i = 0; i <= array2D.Rank; i++)
                    {
                        bool loopBroken = false;
                        for (int j = 0; j <= array2D.Rank; j++)
                        {

                            if (count == locationNumber)
                            {
                                if (array2D[i, j] != "X" && array2D[i, j] != "O")
                                {
                                    array2D[i, j] = whoseTurnItIs;
                                    loopBroken = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter a Valid Location");
                                    loopBroken = true;
                                    whoseTurnItIs = ChangeTurn(whoseTurnItIs);
                                    break;
                                }

                            }
                            count++;
                        }
                        if (loopBroken) break;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a number not a string");
                    whoseTurnItIs = ChangeTurn(whoseTurnItIs);
                }

                

                if (array2D[0, 0] == whoseTurnItIs  && array2D[0, 1] == whoseTurnItIs  && array2D[0, 2] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;

                }
                if (array2D[1, 0] == whoseTurnItIs && array2D[1, 1] == whoseTurnItIs && array2D[1, 2] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }
                if (array2D[2, 0] == whoseTurnItIs && array2D[2, 1] == whoseTurnItIs && array2D[2, 2] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }
                if (array2D[0, 0] == whoseTurnItIs && array2D[1, 0] == whoseTurnItIs && array2D[2, 0] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }
                if (array2D[0, 1] == whoseTurnItIs && array2D[1, 1] == whoseTurnItIs && array2D[2, 1] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }
                if (array2D[0, 2] == whoseTurnItIs && array2D[1, 2] == whoseTurnItIs && array2D[2, 2] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }
                if (array2D[0, 0] == whoseTurnItIs && array2D[1, 1] == whoseTurnItIs && array2D[2, 2] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }
                if (array2D[2, 0] == whoseTurnItIs && array2D[1, 1] == whoseTurnItIs && array2D[0, 2] == whoseTurnItIs)
                {
                    if (AfterWinning(whoseTurnItIs))
                    {
                        array2D = ResetGame(array2D);
                    }
                    else break;
                }

                count = 1;
                whoseTurnItIs = ChangeTurn(whoseTurnItIs);
            }

            Console.ReadKey();
        }

        static string ChangeTurn(string playerTurn)
        {
            if (playerTurn == "X") return "O";
            else return "X";
        }

        static string [,] ResetGame(string[,] array)
        {
            int locationNumber = 1;
            for (int i = 0; i <= array.Rank; i++)
            {
                for (int j = 0; j <= array.Rank; j++)
                {
                    array[i, j] = locationNumber.ToString();
                    locationNumber++;
                }
            }
            return array;
        }

        static bool AfterWinning(string whoseTurnItIs)
        {
            Console.WriteLine("Player " + whoseTurnItIs + " has won");
            Console.WriteLine("Do you want to reset the Game?  Press 1 to reset, 2 to Quit");
            string playerInput = Console.ReadLine();
            int playerInputNumber = int.Parse(playerInput);
            if (playerInputNumber == 1)
            {
                return true;
            }
            return false; 
        }
    }
}
