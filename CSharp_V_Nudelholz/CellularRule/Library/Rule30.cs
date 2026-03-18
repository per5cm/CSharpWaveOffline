using System;
using System.Collections.Generic;
using System.Text;

namespace CellularRule.Library
{
    internal class Rule30
    {
        internal static int CellularRule30()
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

            cellularBlankArray[width / 2] = positiv;

            int generation = 0;

            while (!end)
            {
                Console.Clear();

                Console.Write($"Generation: {0}", generation);



                generation++;

                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case endButton: end = true; break;
                    default: break;
                }
            }

            return width;
        }
    }
}
