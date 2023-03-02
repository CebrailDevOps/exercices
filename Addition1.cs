using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class Addition1 : iCommand
    {
        public string Name => "01_Addition";

        public void Execute()
        {
            int nb1, nb2;
            nb1 = int.Parse(Console.ReadLine());
            nb2 = int.Parse(Console.ReadLine());
            Console.WriteLine(nb1 + nb2);
        }
    }
}
