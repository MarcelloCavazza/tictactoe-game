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
        static char[,] tictactoeTable = new char[3,3]
        {
            {'_', '_', '_'},
            {'_', '_', '_'},
            {'_', '_', '_'},
        };
        static void Main(string[] args)
        {
            bool gameIsOver = false;

            while (!gameIsOver)
            {
                Console.WriteLine("TIC TAC TOE!");
                Console.WriteLine("Insert O or X");
                char userLetter = 'n', computerLetter = 'n';
                byte userChoiceColumnPosition = 0;
                byte userChoiceLinePosition = 0;
                bool userAnwserredCorrect = false;
                while (!userAnwserredCorrect)
                {
                    string userChoice = Console.ReadLine().ToUpper();
                    bool result = userChoiceVerification(userChoice);
                    if (result)
                    {
                        userAnwserredCorrect = true;
                        userLetter = 'X';
                        switch (userLetter)
                        {
                            case 'X':
                                computerLetter = 'Y';
                                break;
                            case 'Y':
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
                // TODO: arrumar tratamento de erro de coluna 
                bool positionIsValid = false;
                while (!positionIsValid)
                {
                    try
                    {
                        Console.WriteLine("Choose a column position:");
                        userChoiceColumnPosition = byte.Parse(Console.ReadLine());
                        positionIsValid = true;
                    }
                    catch (FormatException exception)
                    {
                        Console.WriteLine("Choose a column position:");
                    }
                }

                positionIsValid = false;
                while (!positionIsValid)
                {
                    try
                    {
                        Console.WriteLine("Choose a line position:");
                        userChoiceLinePosition = byte.Parse(Console.ReadLine());
                        positionIsValid = true;
                    }
                    catch (FormatException exception)
                    {
                        Console.WriteLine("Choose a line position:");
                    }
                }
                tictactoeTable[userChoiceColumnPosition, userChoiceLinePosition] = 'X';
                showTable();
            }
        }

        static void showTable()
        {
            for (int i = 0; i < tictactoeTable.GetLength(0);i++) {
                for (int j = 0; j < tictactoeTable.GetLength(1); j++)
                {
                    if(j == 1)
                    {
                        Console.Write(" ");
                        Console.Write(tictactoeTable[i, j]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(tictactoeTable[i, j]);
                    }
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
            if (userChoice != "O" && userChoice != "X")
            {
                Console.WriteLine("Choose only O or X");
                return false;
            }
            return true;

        }
    }
}
