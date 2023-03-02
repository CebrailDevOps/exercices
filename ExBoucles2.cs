using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExBoucles2 : iCommand
    {
        public string Name => "02_ExBoucles";

        public void Execute()
        {
            Console.Write("Factoriel de : ");
            int nb;
            bool b = int.TryParse(Console.ReadLine(), out nb);
            long nb2 = 1;
            if (true)
            {
                for (int i = 1; i <= nb; i++)
                {
                    nb2 *= i;
                }
                Console.WriteLine($"Le factoriel de {nb} est égal à {nb2}.");
            }
            else
            {
                Console.WriteLine("Erreur");
            }
        }
    }
}
