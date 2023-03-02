using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExBoucles5 : iCommand
    {
        public string Name => "05_ExBoucles";

        public void Execute()
        {
            string a;
            for (double i = 0.0; i < 20.1; i+=0.1)
            {
                a = i.ToString("0.0");
                Console.WriteLine(a);
            }
        }
    }
}
