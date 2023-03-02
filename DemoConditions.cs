using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoConditions : iCommand
    {
        public string Name => "01_Conditions";

        public void Execute()
        {
            int age;
            string nom;
            Console.Write("Nom : ");
            nom = Console.ReadLine();
            Console.Write("Âge : ");
            if(int.TryParse(Console.ReadLine(), out age))
            {
                if(age >= 18)
                {
                    Console.WriteLine($"Bienvenue {nom}");
                }
                else if(age >= 16)
                {
                    Console.WriteLine($"Reviens dans quelques années, {nom}.");
                }
                else if(age >=14)
                {
                    Console.WriteLine($"T'es encore trop jeune, {nom}.");
                }
                else
                {
                    Console.WriteLine("Retourne chez ta maman, petit.");
                }
            }
            else
            {
                Console.WriteLine("Valeur incorrecte");
            }
            int choix;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 : Citron");
            sb.AppendLine("2 : Oragne");
            sb.AppendLine("3 : Pamplemousse");
            sb.AppendLine("4 : Ananas");
            sb.AppendLine("5 : Pastèque");
            Console.WriteLine(sb.ToString());
            if(int.TryParse(Console.ReadLine(),out choix))
            {
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("🍋Les citrons coûtent 2€/kg");
                        break;
                    case 2:
                        Console.WriteLine("🍊Les oranges coûtent 1.5€/kg");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("🍈🍍Les pamplemousses, ananas et pastèques coûtent 2.5€/kg");
                        break;
                    default: Console.WriteLine("Choix non valide"); break;
                }
            }
            else
            {
                Console.WriteLine("Valeur incoorecte");
            }
            Console.WriteLine("Au revoir 👋");
        }
    }
}
