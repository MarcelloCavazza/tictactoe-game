﻿using System;
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
            {"0" , "0", "0" },
            {"1" , "1" , "1" },
            {"2" , "2" , "2"},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("TIC TAC TOE!");
            Console.WriteLine("Insert O or X");
            bool userAnwserredCorrect = false;
            while (!userAnwserredCorrect)
            {
                string userChoice = Console.ReadLine();
                bool result = userChoiceVerification(userChoice);
                if (result)
                {
                    userAnwserredCorrect = true;
                }
            }
            showTable();




        }

        static void showTable()
        {
            for (int i = 0; i < tictactoeTable.GetLength(0);i++) {
                for (int j = 0; j < tictactoeTable.GetLength(1); j++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write(tictactoeTable[i, j]);
                            break;
                        case 1:
                            Console.Write(tictactoeTable[i, j]);
                            break;
                        case 2:
                            Console.Write(tictactoeTable[i, j]);
                            break;
                        default:
                            break;
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