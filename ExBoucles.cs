using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExBoucles : iCommand
    {
        public string Name => "01_ExBoucles";

        public void Execute()
        {
            int nb1 = 0;
            int nb2 = 1;
            int nb3;
            for (int i = 0; i < 24; i++)
            {
                nb3 = nb1 + nb2;
                nb1 = nb2;
                nb2 = nb3;
                Console.WriteLine(nb3);
            }
        }
    }
}
