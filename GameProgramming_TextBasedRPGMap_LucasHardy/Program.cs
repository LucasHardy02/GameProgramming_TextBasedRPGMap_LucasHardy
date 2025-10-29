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
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static void Main(string[] args)
        {
            DisplayMap(2);
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
                    
                    Console.Write(mapArray[y, x]);
                    

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

            for (int y = 0; y < mapArray.GetLength(0) - 1; y++)
            {
               
                Console.Write('║');

                

                for (int i = 0; i < scale; i++)
                {
                    
                    for (int x = 0; x < mapArray.GetLength(1); x++)
                    {
                       

                        for (int j = 0; j < scale; j++)
                        {
                            
                            Console.Write(mapArray[y, x]);
                        }
                        


                    }
                }


                Console.Write('║');

                Console.Write("\n");


            }
            for (int i = 0; i < mapArray.GetLength(1) * scale + 2; i++)
            {
                Console.Write(topBottomBorder);
            }
        }
    }
}


