using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char player = 'X';
    static int choice;
    static int flag = 0;

    static void Main()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");
            if (player == 'X')
            {
                Console.WriteLine("Turn Player 1");
            }
            else
            {
                Console.WriteLine("Turn Player 2");
            }
            Console.WriteLine("\n");
            Board();
            choice = int.Parse(Console.ReadLine());

            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                if (player == 'X')
                {
                    board[choice - 1] = 'X';
                    player = 'O';
                }
                else
                {
                    board[choice - 1] = 'O';
                    player = 'X';
                }
            }
            else
            {
                Console.WriteLine("Sorry, the row {0} is already marked with a {1}.", choice, board[choice - 1]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait 2 seconds, the board is loading again...");
                System.Threading.Thread.Sleep(2000);
            }
            flag = CheckWin();
        } while (flag != 1 && flag != -1);

        Console.Clear();
        Board();
        if (flag == 1)
        {
            Console.WriteLine("Player {0} has won!", (player == 'X') ? 2 : 1);
        }
        else
        {
            Console.WriteLine("Draw!");
        }
        Console.ReadLine();
    }

    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }

    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        if (board[0] == board[1] && board[1] == board[2])
        {
            return 1;
        }
        else if (board[3] == board[4] && board[4] == board[5])
        {
            return 1;
        }
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        else if (board[0] == board[3] && board[3] == board[6])
        {
            return 1;
        }
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condition
        else if (board[0] == board[4] && board[4] == board[8])
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6])
        {
            return 1;
        }
        #endregion

        #region Checking For Draw
        else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }
}
