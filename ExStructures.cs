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
            Point?[,] points = new Point?[5, 5];
            for (int i = 0; i < points.GetLength(0); i++)
            {
                points[i,i] = new Point(i+1,i+1);
            }
            for (int i = 0;i < points.GetLength(1); i++) 
            { 
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    if (points[i,j] is null)
                    {
                        Console.Write(new string(' ',13));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x; Y = y;
        }
        public int X, Y;

        public override string ToString()
        {
            return $"X : {X} - Y : {Y}";
        }
    }
}
