using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExBoucles6 : iCommand
    {
        public string Name => "06_ExBoucles";

        public void Execute()
        {
            double nb,r;
            Console.Write("Tu veux calculer la racine carrée de quel nombre ? ");
            bool b = double.TryParse(Console.ReadLine(), out nb);
            string nombreAvecDecimale;
            r = Math.Sqrt(nb);
            if (r % 1 == 0)
            {
                nombreAvecDecimale = r.ToString("0");
            }
            else
            {
                nombreAvecDecimale = r.ToString("0.##########");
            }
            Console.WriteLine($"La racine carrée de {nb} est égale à {nombreAvecDecimale}.");
        }
    }
}
