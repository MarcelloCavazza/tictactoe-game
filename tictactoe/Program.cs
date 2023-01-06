using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    internal class Program
    {
        static string[,] tictactoeTable =
        {
            {"_ " , "_", " _" },
            {"_ " , "_" , " _" },
            {"_ " , "_" , " _"},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("TIC TAC TOE!");
            Console.WriteLine("Insert O or X");
            char userLetter = 'n', computerLetter = 'n';
            bool userAnwserredCorrect = false;
            while (!userAnwserredCorrect)
            {
                string userChoice = Console.ReadLine();
                bool result = userChoiceVerification(userChoice);
                if (result)
                {
                    userAnwserredCorrect = true;
                    switch(userChoice.ToUpper())
                    {
                        case "X":
                            userLetter = 'X';
                            computerLetter = 'Y';
                            break;
                        case"Y":
                            userLetter = 'Y';
                            computerLetter = 'X';
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("TIC TAC TOE!");
            showTable();
            Console.WriteLine("");
            Console.Write("Choosed Letter: ");
            Console.WriteLine(userLetter);
            Console.WriteLine("");
            Console.WriteLine("Choose a position and write down the X:");
            //int userChoiceForX = int.TryParse(Console.ReadLine(), out var resultX);
            Console.WriteLine("Choose a position and write down the Y:");
            //int userChoiceForY = int.TryParse(Console.ReadLine(), out var resultY);


        }

        static void showTable()
        {
            for (int i = 0; i < tictactoeTable.GetLength(0);i++) {
                for (int j = 0; j < tictactoeTable.GetLength(1); j++)
                {
                    Console.Write(tictactoeTable[i, j]);
                    if (j == 2)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        static bool userChoiceVerification(string userChoice)
        {
            bool lengthVerf = lengthVerification(userChoice);
            if (lengthVerf)
            {
                bool letterVerf = letterVerification(userChoice);
                if (letterVerf)
                {
                    return true;
                }
            }
            return false;
        }

        static bool lengthVerification(string userChoice)
        {
            if(userChoice.Length > 1)
            {
                Console.WriteLine("Choose only O or X");
                return false;
            }
            return true;
        }
        static bool letterVerification(string userChoice)
        {
            if (userChoice.ToUpper() != "O" && userChoice.ToUpper() != "X")
            {
                Console.WriteLine("Choose only O or X");
                return false;
            }
            return true;

        }
    }
}
