using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    internal class ExEnums1 : iCommand
    {
        public string Name => "01_ExEnums";

        public void Execute()
        {
            Carte c;
            string[] cartes = new string[52];
            int i = 0;
            
            foreach (Couleurs couleur in Enum.GetValues<Couleurs>())
            {
                foreach (Valeurs valeur in Enum.GetValues<Valeurs>())
                {
                    c.Couleur = couleur.ToString();
                    c.Valeur = valeur.ToString();
                    cartes[i] = $"{c.Valeur} de {c.Couleur}";
                    i++;
                }
            }
            foreach (string item in cartes)
            {
                Console.WriteLine(item);
            }
        }
        public enum Couleurs
        {
            Coeur,
            Carreau,
            Pique,
            Trefle
        }
        public enum Valeurs
        {
            Deux = 2,
            Trois = 3,
            Quatre = 4,
            Cinq = 5,
            Six = 6,
            Sept = 7,
            Huit = 8,
            Neuf = 9,
            Dix = 10,
            Valet = 11,
            Dame = 12,
            Roi = 13,
            As = 14
        }
        public struct Carte
        {
            public string Couleur;
            public string Valeur;
        }
    }
}
