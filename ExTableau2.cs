using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExTableau2 : iCommand
    {
        public string Name => "02_ExTableau";

        public void Execute()
        {
            int x, y;
            bool a, b;
            Console.Write("Choisis la dimension de ta map 2D (minimum 5x5). Profondeur : ");
            a = int.TryParse(Console.ReadLine(), out x);
            Console.Write("Largeur : ");
            b = int.TryParse(Console.ReadLine(), out y);
            if (a && b && x > 4 && y > 4)
            {
                string[,] tab2Dim = new string[y, x];

                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (i == y-1)
                        {
                            tab2Dim[y-1, j] = "#";
                        }
                        else if (i == 0)
                        {
                            tab2Dim[0, j] = "#";
                        }
                        else if (j == x-1)
                        {
                            tab2Dim[i, x - 1] = "#";
                        }
                        else if (j == 0)
                        {
                            tab2Dim[i, 0] = "#";
                        }
                        else
                        {
                            tab2Dim[i, j] = " ";
                        }
                    }
                }
                tab2Dim[1, 1] = "X";
                int[] z = { 1, 1 };
                b = true;
                Random rnd = new Random();
                int[] t1 = { rnd.Next(1, y-1), rnd.Next(1, x-1) };
                bool t1Del = false;
                do
                {
                    Console.Clear();
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            if (i == y - 1)
                            {
                                tab2Dim[y - 1, j] = "#";
                            }
                            else if (i == 0)
                            {
                                tab2Dim[0, j] = "#";
                            }
                            else if (j == x - 1)
                            {
                                tab2Dim[i, x - 1] = "#";
                            }
                            else if (j == 0)
                            {
                                tab2Dim[i, 0] = "#";
                            }
                            else
                            {
                                tab2Dim[i, j] = " ";
                            }
                        }
                    }
                    if (t1Del)
                    {
                        tab2Dim[t1[0], t1[1]] = ".";
                    }
                    else
                    {
                        tab2Dim[t1[0], t1[1]] = "T";
                    }
                    tab2Dim[z[0], z[1]] = "X";
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            Console.Write(tab2Dim[i, j]);
                        }
                        Console.WriteLine(" ");
                    }
                    Console.Write("Tape z, q, s ou d pour te déplacer, c pour couper et x pour stoper : ");
                    ConsoleKeyInfo d = Console.ReadKey();
                    switch (d.KeyChar)
                    {
                        case 'z': 
                            if (z[0] != 1 && (z[0]-1 != t1[0] || z[1] != t1[1] || t1Del))
                            {
                                z[0]--;
                            }
                            break;
                        case 'q':
                            if (z[1] != 1 && (z[1]-1 != t1[1] || z[0] != t1[0] || t1Del))
                            {
                                z[1]--;
                            }
                            break;
                        case 's':
                            if (z[0] != y-2 && (z[0]+1 != t1[0] || z[1] != t1[1] || t1Del))
                            {
                                z[0]++;
                            }
                            break;
                        case 'd':
                            if (z[1] != x- 2 && (z[1]+1 != t1[1] || z[0] != t1[0] || t1Del))
                            {
                                z[1]++;
                            }
                            break;
                        case 'c':
                            if ((z[0]-1 == t1[0] && z[1] == t1[1]) || (z[0]+1 == t1[0] && z[1] == t1[1]) || (z[1] - 1 == t1[1] && z[0] == t1[0]) || (z[1] + 1 == t1[1] && z[0] == t1[0]))
                            {
                                t1Del = true;
                            }
                            break;
                        case 'x':
                            b = false;
                            break;
                        default:
                            break;
                    }
                } while (b);
                Console.WriteLine("\nMerci d'avoir joué, au revoir.");
            }
        }
    }
}
