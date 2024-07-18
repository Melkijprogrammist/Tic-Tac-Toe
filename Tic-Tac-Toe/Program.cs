using System;

namespace TicTackToe
{
    class Program
    {
        static char[,] board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static int currentPlayer = 1;
        static int choise;
        static bool GameOver = false;

        static void Main(string[] args)
        {
            do
            {
                Board();
                PlayerMove ();
                IsGameOver();
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }while(!GameOver);
            Board();
            if (GameOver)
            {
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
                Console.WriteLine($"Игрок {currentPlayer} выиграл!");
            }
            static void Board()
            {
                Console.Clear();
                Console.WriteLine("Крестики-Нолики");
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("    |    |");
                    Console.WriteLine($"  {board[i, 0]} | {board[i, 1]} | {board[i, 2]} ");
                    Console.WriteLine("____|____|____");
                }
            }
            static void PlayerMove()
            {
                Console.WriteLine($"Ход игрока{currentPlayer}:");
                choise = int.Parse(Console.ReadLine());

                char playerChar = (currentPlayer == 1) ? 'X' : 'O';

                switch (choise)
                    {
                    case 1:
                        if (board[0, 0] != 'X' && board[0, 0] != 'O') board[0, 0] = playerChar;
                        else PlayerMove();
                        break;
                    case 2:
                        if (board[0, 1] != 'X' && board[0, 1] != 'O') board[0, 1] = playerChar;
                        else PlayerMove();
                        break;
                    case 3:
                        if (board[0, 2] != 'X' && board[0, 2] != 'O') board[0, 2] = playerChar;
                        else PlayerMove();
                        break;
                    case 4:
                        if (board[1, 0] != 'X' && board[1, 0] != 'O') board[1, 0] = playerChar;
                        else PlayerMove();
                        break;
                    case 5:
                        if (board[1, 1] != 'X' && board[1, 1] != 'O') board[1, 1] = playerChar;
                        else PlayerMove();
                        break;
                    case 6:
                        if (board[1, 2] != 'X' && board[1, 2] != 'O') board[1, 2] = playerChar;
                        else PlayerMove();
                        break;
                    case 7:
                        if (board[2, 0] != 'X' && board[2, 0] != 'O') board[2, 0] = playerChar;
                        else PlayerMove();
                        break;
                    case 8:
                        if (board[2, 1] != 'X' && board[2, 1] != 'O') board[2, 1] = playerChar;
                        else PlayerMove();
                        break;
                    case 9:
                        if (board[2, 2] != 'X' && board[2, 2] != 'O') board[2, 2] = playerChar;
                        else PlayerMove();
                        break;
                    default:
                        PlayerMove();
                        break;
                }
            }
            static void IsGameOver()
            {
                if ((board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2]) ||
                (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2]) ||
                (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2]) ||
                (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0]) ||
                (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1]) ||
                (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2]) ||
                (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
                {
                    GameOver = true;
                }
                else
                {
                    bool isBoardFull = true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] != 'X' && board[i, j] != 'O')
                            
                                {
                                isBoardFull = false;
                                break;
                            }
                        }
                    }
                    if (isBoardFull) GameOver = true;
                }
            }
        }
    }
}