using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoMethodes : iCommand
    {
        public string Name => "01_DemoMethodes";

        public void Execute()
        {
            Console.WriteLine("Taille : ");
            int taille = int.Parse(Console.ReadLine());

            int[] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] tab2 = new int[taille, taille];

            AfficherTableau(tab1);
        }

        public void AfficherTableau(int[] tab1)
        {
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " | ");
            }
            Console.WriteLine();
        }
    }
}
