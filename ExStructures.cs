using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    internal class ExStructures : iCommand
    {
        public string Name => "01_ExStructures";

        public void Execute()
        {
            const int y = 5;
            const int x = 5;
            string[,] tab2Dim = new string[y, x];
            for (int i = 0; i < y-1; i++)
            {
                for (int j = 0; j < x-1; j++)
                {
                    if (i == j)
                    {
                        Coord coord = new Coord();
                        coord.X = i+1;
                        coord.Y = j+1;
                        Console.WriteLine($"X : {coord.X} - Y : {coord.Y}");
                    }
                    else
                    {
                        tab2Dim[i, j] = "\t";
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
    public struct Coord
    {
        public int X, Y;
    }
}
