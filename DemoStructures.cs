using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    internal class DemoStructures : iCommand
    {
        public string Name => "01_DemoStructures";

        public void Execute()
        {
            Pokemon pikachu = new Pokemon("Pikachu",20,7,3,15);
            Pokemon ratata = new Pokemon("Ratata", 15, 8, 5, 12);

            pikachu.Attaque(ratata);

        }
    }
    public struct Pokemon
    {
        public string Name;
        int Pv;
        int Atk;
        int Def;
        int Vit;
        public Pokemon(string name, int pv, int atk, int def, int vit)
        {
            Name = name;
            Pv = pv;
            Atk = atk;
            Def = def;
            Vit = vit;
        }
        public void Attaque(Pokemon p)
        {
            Console.WriteLine($"{Name} attaque {p.Name} et fait {Atk} dégâts.");
            p.Pv -= Atk;
            Console.WriteLine($"{p.Name} a maintenant {p.Pv} pv.");
        }
    }
}
