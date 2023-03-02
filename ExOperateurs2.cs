using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExOperateurs2 : iCommand
    {
        public string Name => "02_ExOperateurs";

        public void Execute()
        {
            Console.Write("BBAN : ");
            string BBAN = Console.ReadLine();
            if (BBAN.Length == 12)
            {
                long BBAN10Prem = long.Parse(BBAN.Substring(0, 10));
                int BBAN2Der = int.Parse(BBAN.Substring(10, 2));
                int modulo = (int)(BBAN10Prem % 97);
                Console.WriteLine(BBAN2Der == ((modulo == 0) ? 97 : modulo) ? "OK" : "KO");
            }
            else
            {
                Console.WriteLine("KO");
            }
        }
    }
}
