using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CellularRule.Library
{
    internal class Rule30
    {
        internal static void CellularRule30()
        {
            int width = 80;

            int[] currentArray = new int[width];

            int [] nextArray = new int[width];

            int positiv = 0b0001;
            //int negativ = 0b0000;

            #region UserDirection

            bool end = false;
            //const ConsoleKey endButton = ConsoleKey.Q;

            #endregion

            currentArray[width / 2] = positiv; // or 1

            int generation = 0;

            while(!end && generation < width)
            {
                //Console.Clear();

                //Console.WriteLine($"Generation: {generation}");

                for (int row = 0; row < width; row++ )
                {
                    if (currentArray[row] == positiv) Console.Write("X");
                    else Console.Write(".");
                }
                Console.WriteLine();

                for (int row = 0;row < width; row++ )
                {
                    int left = (row > 0) ? currentArray[row -1] : 0;
                    int center = currentArray[row];
                    int right = (row < width -1) ? currentArray[row +1] : 0;

                    int code = (left << 2) | (center << 1) | right;

                    switch (code)
                    {
                        case 0b000: nextArray[row] = 0; break; // --> 000 --> 0
                        case 0b001: nextArray[row] = 1; break; // --> 001 --> 1
                        case 0b010: nextArray[row] = 1; break; // --> 010 --> 1
                        case 0b011: nextArray[row] = 1; break; // --> 011 --> 1
                        case 0b100: nextArray[row] = 1; break; // --> 100 --> 1
                        case 0b101: nextArray[row] = 0; break; // --> 101 --> 0
                        case 0b110: nextArray[row] = 0; break; // --> 110 --> 0
                        case 0b111: nextArray[row] = 0; break; // --> 111 --> 0
                    }
                }

                Array.Copy(nextArray, currentArray, width);
                generation++;
                
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Q)
                        end = true;
                }
            }
        }
    }
}
