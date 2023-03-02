using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class PairImpair : iCommand
    {
        public string Name => "Pair ou Impair";

        public void Execute()
        {
            int nb;
            bool b = int.TryParse(Console.ReadLine(), out nb);
            Console.WriteLine((nb % 2 == 0) ? "Pair" : "Impair");
        }
    }
}
