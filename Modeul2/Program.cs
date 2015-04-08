using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeul2
{
    class Program
    {
        static void Main(string[] args)
        {
            const char blackCell = 'X';
            const char whiteCell = 'O';
            const int rowCount = 8;
            const int colCount = 8;
            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write(" {0} ", ((row % 2 == 0) && (col % 2 == 0)) || ((row % 2 != 0) && (col % 2 != 0)) ? blackCell : whiteCell);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
