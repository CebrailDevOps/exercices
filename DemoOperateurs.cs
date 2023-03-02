using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoOperateurs : iCommand
    {
        public string Name => "01_Opérateurs";

        public void Execute()
        {
            int nb = 5;
            Console.WriteLine(nb++); // nb reste a 5 mais devient 6 après cette ligne
            Console.WriteLine(nb);
            Console.WriteLine(++nb);
            nb += 3;
            Console.WriteLine(nb);
            nb *= 2;
            Console.WriteLine(nb);
            nb /= 4;
            Console.WriteLine(nb);

            string status = (nb == 5) ? "nb vaut 5" : "nb ne vaut pas 5";
            Console.WriteLine(status);
            string? a = null;
            string? b = "Toto";
            string? c = null;
            string? d = "Lili";

            string result = a ?? "a est null";
            Console.WriteLine(result);
            result = b ?? "a est null";
            Console.WriteLine(result);
            result = a ?? c ?? "a et c sont null";
            Console.WriteLine(result);
            result = a ?? b ?? c ?? "a, b et c sont null";
            Console.WriteLine(result);
            result = a ?? b ?? c ?? d ?? "a, b, c et d sont null";
            Console.WriteLine(result);
        }
    }
}
