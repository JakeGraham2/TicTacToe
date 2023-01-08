using System;

namespace game
{
   class ticTacToe
   {
      static void Main(string[] args)
      {
         string currentPlayer = "x";
         List<string> board = new List<string>{"1","2","3","4","5","6","7","8","9"};
         while (!IsGameOver(board))
         {
            DisplayBoard(board);
            Console.Write($" It's {currentPlayer}'s turn");
            GetPlayerMove(board,currentPlayer);
            currentPlayer = GetPlayer(currentPlayer);
         }
      }
   //this will display the board
      static void DisplayBoard(List<string> board)
      {
         Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
         Console.WriteLine("-+-+-");
         Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
         Console.WriteLine("-+-+-");
         Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
      }
      static bool IsGameOver( List<string> board)
      {
        bool isWinner = false;
        //rows
        if ((board[0] == board[1] && board[1] == board[2]))
        {
         isWinner = true;
        }
        else if ((board[3] == board[4]&& board[4] == board[5]))
        {
         isWinner = true;
        }
        else if ((board[6] == board[7]&& board[7] == board[8]))
        {
         isWinner = true;
        }
        // columns
        else if((board[0] == board[3]&& board[3] == board [6]))
        {
         isWinner = true;
        }
        else if ((board[1] == board[4]&& board[4] == board[7]))
        {
         isWinner = true;
        }
        else if ((board[2] == board[5]&& board[5] == board[8]))
        {
         isWinner = true;
        }
        //diagonal
        else if ((board[0] == board[4]&& board[4] == board[8]))
        {
         isWinner = true;
        }
        else if ((board[2] == board[4]&& board[4] == board[6]))
        {
         isWinner = true;
        }
        return isWinner;
      }
      static string GetPlayer(string currentPlayer)
      {
         string nextPlayer = "x";
         if (currentPlayer == "x")
         {
            nextPlayer = "o";
         }
         return nextPlayer;
      }
      static void GetPlayerMove(List <string> board, string currentPlayer)
      {
         bool value = false;
         while(!value)
         { 
            Console.Write($"to choose a square (1-9):");
            string playerMove = Console.ReadLine();
            int playerMoveInt = Convert.ToInt32 (playerMove);
            if(board[playerMoveInt] == "x" || board[playerMoveInt] == "o" )
            {
               Console.WriteLine($"You returned {playerMove}");
            }
            if(playerMoveInt <= 9 || playerMoveInt >= 1)
            {
               value = true;
               Console.WriteLine($"You returned {playerMove}");
            }
            else
            {
               playerMove = ($"{playerMoveInt}");
               value = true;
            }
            if (value)
            {
               board [playerMoveInt - 1] = currentPlayer;
            }
         }
      }

   }
}

