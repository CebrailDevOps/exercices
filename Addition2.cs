using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class Addition2 : iCommand
    {
        public string Name => "02_Addition";

        public void Execute()
        {
            int nb1, nb2;
            bool b = int.TryParse(Console.ReadLine(), out nb1);
            if (!b)
            {
                Console.WriteLine("Vous n'avez pas écrit un nombre entier. Le premier nombre est donc considéré comme 0.");
            }
            b = int.TryParse(Console.ReadLine(), out nb2);
            if (!b)
            {
                Console.WriteLine("Vous n'avez pas écrit un nombre entier. Le second nombre est donc considéré comme 0.");
            }
            Console.WriteLine(nb1 + nb2);
        }
    }
}
