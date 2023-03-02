using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExBoucles3 : iCommand
    {
        public string Name => "03_ExBoucles";

        public void Execute()
        {
            Console.Write("Je dois trouver combien de nombres premiers ? ");
            int nb;
            bool b = int.TryParse(Console.ReadLine(), out nb);
            DateTime start = DateTime.Now;
            bool test = false;
            int count = 1;
            int nbPremier = 2;
            if (b && nb > 0)
            {
                while (count < nb)
                {
                    nbPremier++;
                    test = false;
                    if (nbPremier%2 !=0)
                    {
                        int sqrt = (int)Math.Sqrt(nbPremier);
                        for (int i = 3; i <= sqrt && !test; i+=2)
                        {
                            if (nbPremier%i == 0)
                            {
                                test = true;
                            }
                        }
                        if (!test)
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Le dernier nombre premier que j'ai trouvé est {nbPremier}.");
                Console.WriteLine((DateTime.Now - start).TotalSeconds);
            }
        }
    }
}
