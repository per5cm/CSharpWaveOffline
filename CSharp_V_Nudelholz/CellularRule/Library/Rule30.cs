using System;
using System.Collections.Generic;
using System.Text;

namespace CellularRule.Library
{
    internal class Rule30
    {
        internal static void CellularRule30()
        {
            int width = 80;

            int[] cellularBlankArray = new int[width];

            int[] cellularFinalArray = new int[width];

            int positiv = 0b0001;
            int negativ = 0b0000;

            #region UserDirection

            bool end = false;
            const ConsoleKey endButton = ConsoleKey.Q;

            #endregion

            cellularBlankArray[width / 2] = positiv; // or 1

            int generation = 0;

            while (!end)
            {
                Console.Clear();

                Console.Write($"Generation: ", generation);

                for (int row = 0; row < width; row++ )
                {
                    if (cellularBlankArray[row] == 1) Console.Write("X");
                    else Console.Write(".");
                }
                Console.WriteLine();

                generation++;

                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case endButton: end = true; break;
                    default: break;
                }
            }
        }
    }
}
