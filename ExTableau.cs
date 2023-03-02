using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExTableau : iCommand
    {
        public string Name => "01_ExTableau";

        public void Execute()
        {
            Console.Write("Tu veux connaître tous les nombres premiers jusqu'à quel nombre ? ");
            int nb;
            bool b = int.TryParse(Console.ReadLine(), out nb);
            DateTime start = DateTime.Now;
            bool test = false;
            int nbPremier = 2;
            List<int> list = new List<int>();
            list.Add(nbPremier);
            if (b && nb > 1)
            {
                while (nbPremier < nb)
                {
                    nbPremier++;
                    test = false;
                    if (nbPremier % 2 != 0)
                    {
                        int sqrt = (int)Math.Sqrt(nbPremier);
                        for (int i = 3; i <= sqrt && !test; i += 2)
                        {
                            if (nbPremier % i == 0)
                            {
                                test = true;
                            }
                        }
                        if (!test)
                        {
                            list.Add(nbPremier);
                        }
                    }
                }
                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
