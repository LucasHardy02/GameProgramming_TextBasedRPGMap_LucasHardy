using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_TextBasedRPGMap_LucasHardy
{
    internal class Program
    {
        static char[,] mapArray = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','"','"','"','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','"','"','~','~','~','"','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','"','~','~','~','"','"','`','`','`'},
        {'^','`','`','`','"','"','"','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','"','"','"','`','`','`','`','`'},
        {'`','`','`','"','~','~','~','"','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','"','~','~','~','"','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','"','~','~','~','~','"','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','"','"','~','~','~','"','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','"','~','~','~','~','"','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','"','"','~','"','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','"','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };

        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("map legend:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("^ = mountain");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("` = grass");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~ = waters");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\" = sand");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("* = tree");
        }


        static void Main(string[] args)
        {
            DisplayMap(3);
            ShowHUD();
            Console.ReadKey();
        }

        static void DisplayMap()
        {
            string topBottomBorder = "═";

            for(int i = 0; i < mapArray.GetLength(1) + 2; i++)
            {
                Console.Write(topBottomBorder);
            }

            Console.Write("\n");

            for (int y = 0; y < mapArray.GetLength(0); y++)
            {
                Console.Write('║');
                for (int x = 0; x < mapArray.GetLength(1); x++)
                {
                    MapColors(mapArray[y, x]);
                    Console.Write(mapArray[y, x]);
                    Console.ResetColor();

                }
                Console.Write('║');
                Console.Write("\n");

                
            }
            for (int i = 0; i < mapArray.GetLength(1) + 2; i++)
            {
                Console.Write(topBottomBorder);
            }
        }
        
        
        static void DisplayMap(int scale)
        {
            string topBottomBorder = "═";

            for (int i = 0; i < mapArray.GetLength(1) * scale + 2; i++)
            {
                Console.Write(topBottomBorder);
            }

            Console.Write("\n");

            for (int y = 0; y < mapArray.GetLength(0); y++)
            {


                for (int i = 0; i < scale; i++)
                {
                    Console.Write('║');


                    for (int x = 0; x < mapArray.GetLength(1); x++)
                    {
                       

                        for (int j = 0; j < scale; j++)
                        {
                            MapColors(mapArray[y, x]);
                            Console.Write(mapArray[y, x]);
                            Console.ResetColor();
                        }
                        


                    }
                    Console.Write('║');
                    Console.Write("\n");


                }






            }
            for (int i = 0; i < mapArray.GetLength(1) * scale + 2; i++)
            {
                Console.Write(topBottomBorder);
            }

            
        }
        static void MapColors(char mapCharacter)
        {
            if (mapCharacter == '^')
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (mapCharacter == '`')
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else if (mapCharacter == '~')
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            else if (mapCharacter == '*')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

            }
            else if (mapCharacter == '"')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ResetColor();
            }
        }
    }
}


