using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class InteretsCumules : iCommand
    {
        public string Name => "Intérêts cumulés";

        public void Execute()
        {
            int nb,annee,taux,inv;
            double r,interets;
            Console.Write("Combien d'argent veux-tu placer en une fois ? ");
            bool b = int.TryParse(Console.ReadLine(), out inv);
            if (b && inv >= 0)
            {
                Console.Write("Combien veux-tu épargner par mois ? ");
                b = int.TryParse(Console.ReadLine(), out nb);
                if (b && nb >= 0)
                {
                    Console.Write("Pendant combien d'année ? ");
                    b = int.TryParse(Console.ReadLine(), out annee);
                    if (b && annee > 0)
                    {
                        Console.Write("Avec quels taux de croissance par an ? ");
                        b = int.TryParse(Console.ReadLine(), out taux);
                        if (b && taux > -100)
                        {
                            r = nb * 12 + inv;
                            interets = ((double)taux / 100) + 1;
                            for (int i = 1; i < annee; i++)
                            {
                                r = Math.Floor(r * interets) + (nb * 12);
                            }
                            Console.WriteLine($"En plaçant {inv} euro et en épargnant {nb} euro par mois avec des taux de croissance par an de +{taux}%, vous aurez {r.ToString("0.##")} euro au bout de {annee} ans.");
                            Console.WriteLine($"Vous aurez investi un total de {(nb*12*annee)+inv} euro en {annee} ans pour avoir {r.ToString("0.##")} euro.");
                        }
                    }
                }
            }
        }
    }
}
