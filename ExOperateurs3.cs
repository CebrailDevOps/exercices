using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExOperateurs3 : iCommand
    {
        public string Name => "03_ExOperateurs";

        public void Execute()
        {
            Console.Write("BBAN : ");
            string BBAN = Console.ReadLine();
            if (BBAN.Length == 12)
            {
                long BBAN10Prem = long.Parse(BBAN.Substring(0, 10));
                int BBAN2Der = int.Parse(BBAN.Substring(10, 2));
                int modulo = (int)(BBAN10Prem % 97);

                if(BBAN2Der == ((modulo == 0)?97:BBAN10Prem%97))
                {
                    string tempIban = BBAN + "111400";
                    int resultat = 98 - (int)(long.Parse(tempIban)%97);
                    string resultIban = ((resultat == 98) ? 1 : resultat).ToString("D2");
                    string IBAN = "BE" + resultIban + BBAN;
                    Console.WriteLine($"Votre n°IBAN : {IBAN}");
                }
                else
                {
                    Console.WriteLine("N° BBAN incorrect.");
                }
            }
            else
            {
                Console.WriteLine("N° BBAN incorrect.");
            }
        }
    }
}
