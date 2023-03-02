using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExBoucles4 : iCommand
    {
        public string Name => "04_ExBoucles";

        public void Execute()
        {
            for (int i = 1; i < 6; i++)
            {
                for(int j = 1; j < 21; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
            }
        }
    }
}
