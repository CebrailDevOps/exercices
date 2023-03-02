using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExOperateurs : iCommand
    {
        public string Name => "01_ExOperateurs";

        public void Execute()
        {
            int nb1, nb2;
            Console.Write("Dividende : ");
            bool b = int.TryParse(Console.ReadLine(), out nb1);
            Console.Write("Diviseur : ");
            b = int.TryParse(Console.ReadLine(), out nb2);
            Console.WriteLine($"{nb1} / {nb2} = {(float)nb1/nb2}\n"+
                $"Le modulo de {nb1} sur {nb2} est {nb1 % nb2}\n"+
                $"La division entière de {nb1} sur {nb2} est {nb1 / nb2}");
        }
    }
}
