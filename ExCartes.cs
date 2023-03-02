using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class ExCartes : iCommand
    {
        public string Name => "Poker";

        public void Execute()
        {
            int miseHero,miseVilain,tapisHero, tapisVilain;
            int pot = 0;
            int jetonHero = 1500;
            int jetonVilain = 1500;
            int p = 0; // impair = Vilain au BTN ; pair = Hero au BTN
            string[] hero = { "x", "x" };
            string[] vilain = { "x", "x" };
            string vilainCard1 = "x";
            string vilainCard2 = "x";
            string heroCard1 = "x";
            string heroCard2 = "x";
            bool b; // y a-t-il eu une relance ?
            bool f = false; // y a-t-il eu un fold ?
            string[] spade = { "2s","3s","4s","5s","6s","7s","8s","9s","Ts","Js","Qs","Ks","As"};
            string[] heart = { "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah" };
            string[] club = { "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac" };
            string[] diamond = { "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad" };
            Random rnd = new Random();
            int type = rnd.Next(1, 5);
            do
            {
                p++;
                switch (type)
                {
                    case 1:
                        heroCard1 = spade[rnd.Next(0, 13)];
                        break;
                    case 2:
                        heroCard1 = heart[rnd.Next(0, 13)];
                        break;
                    case 3:
                        heroCard1 = club[rnd.Next(0, 13)];
                        break;
                    case 4:
                        heroCard1 = diamond[rnd.Next(0, 13)];
                        break;
                }
                do
                {
                    type = rnd.Next(1, 5);
                    switch (type)
                    {
                        case 1:
                            heroCard2 = spade[rnd.Next(0, 13)];
                            break;
                        case 2:
                            heroCard2 = heart[rnd.Next(0, 13)];
                            break;
                        case 3:
                            heroCard2 = club[rnd.Next(0, 13)];
                            break;
                        case 4:
                            heroCard2 = diamond[rnd.Next(0, 13)];
                            break;
                    }
                } while (heroCard1 == heroCard2);
                hero[0] = heroCard1;
                hero[1] = heroCard2;
                do
                {
                    type = rnd.Next(1, 5);
                    switch (type)
                    {
                        case 1:
                            vilainCard1 = spade[rnd.Next(0, 13)];
                            break;
                        case 2:
                            vilainCard1 = heart[rnd.Next(0, 13)];
                            break;
                        case 3:
                            vilainCard1 = club[rnd.Next(0, 13)];
                            break;
                        case 4:
                            vilainCard1 = diamond[rnd.Next(0, 13)];
                            break;
                    }
                } while (vilainCard1 == heroCard1 || vilainCard1 == heroCard2);
                do
                {
                    type = rnd.Next(1, 5);
                    switch (type)
                    {
                        case 1:
                            vilainCard2 = spade[rnd.Next(0, 13)];
                            break;
                        case 2:
                            vilainCard2 = heart[rnd.Next(0, 13)];
                            break;
                        case 3:
                            vilainCard2 = club[rnd.Next(0, 13)];
                            break;
                        case 4:
                            vilainCard2 = diamond[rnd.Next(0, 13)];
                            break;
                    }
                } while (vilainCard2 == heroCard1 || vilainCard2 == heroCard2 || vilainCard2 == vilainCard1);
                hero[0] = vilainCard1;
                hero[1] = vilainCard2;

                if (p%2 == 0)
                {
                    miseHero = 50;
                    jetonHero -= miseHero;
                    miseVilain = 25;
                    jetonVilain -= miseVilain;
                    pot += miseHero + miseVilain;
                    Console.WriteLine($"\nTu es en HU et en BB avec {jetonHero} jetons et ta main es {hero[0]} {hero[1]}.");
                    Console.WriteLine($"Le BTN a déjà mis {miseVilain} jetons et il a toujours {jetonVilain} jetons.");

                    // faire les choix de Vilain

                    Console.WriteLine($"Tu as déjà mis la BB de {miseHero} jetons.");
                }
                else
                {
                    miseHero = 25;
                    jetonHero -= miseHero;
                    miseVilain = 50;
                    jetonVilain -= miseVilain;
                    pot += miseHero + miseVilain;
                    Console.WriteLine($"\nTu es en HU et au BTN avec {jetonHero} jetons et ta main es {hero[0]} {hero[1]}.");
                    Console.WriteLine($"La BB a déjà mis {miseVilain} jetons et il a toujours {jetonVilain} jetons.");
                    Console.WriteLine($"Tu as déjà mis la SB de {miseHero} jetons.");
                }
                do
                {
                    Console.WriteLine($"C'est à ton tour de jouer.");
                    Console.WriteLine($"Le pot total fait {pot} jetons.");
                    Console.WriteLine($"C pour call; F pour fold; R pour raise.");
                    ConsoleKeyInfo d = Console.ReadKey();
                    b = false;
                    do
                    {
                        switch (d.KeyChar)
                        {
                            case 'c':
                                if (jetonHero > miseVilain - miseHero)
                                {
                                    Console.WriteLine("\nVous suivez.");
                                    jetonHero -= miseVilain-miseHero;
                                    pot += miseVilain - miseHero;
                                    miseHero = 0;
                                    miseVilain = 0;
                                    b = true;
                                }
                                else if (jetonHero == miseVilain - miseHero)
                                {
                                    Console.WriteLine("\nVous suivez et vous êtes à tapis.");
                                    jetonHero -= miseVilain - miseHero;
                                    pot += miseVilain - miseHero;
                                    miseHero = 0;
                                    miseVilain = 0;
                                    b = true;
                                }
                                else if (jetonHero < miseVilain - miseHero)
                                {
                                    Console.WriteLine("\nVous misez le reste de vos jetons donc vous êtes à tapis.");
                                    tapisHero = jetonHero;
                                    jetonHero = 0;
                                    jetonVilain += miseVilain - jetonHero;
                                    pot = tapisHero * 2;
                                    miseHero = 0;
                                    miseVilain = 0;
                                    b = true;
                                }
                                break;
                            case 'r':
                                if (jetonHero >= miseVilain*2-miseHero && miseVilain > 0)
                                {
                                    Console.WriteLine("\nVous voulez relancer à combien?");
                                    Console.WriteLine($"A pour {miseVilain*2} jetons, Z pour {miseVilain * 2.5}, E pour {miseVilain * 3} ou R pour All-in.");
                                    ConsoleKeyInfo e = Console.ReadKey();
                                    do
                                    {
                                        switch (e.KeyChar)
                                        {
                                            case 'a':
                                                Console.WriteLine($"\nVous misez {miseVilain * 2}.");
                                                jetonHero -= miseVilain*2 - miseHero;
                                                pot += miseVilain*2 - miseHero;
                                                b = true;
                                                break;
                                        }
                                    } while (!b) ;
                                    
                                }
                                else if (jetonHero == miseVilain - miseHero && miseVilain > 0)
                                {
                                    Console.WriteLine("\nVous suivez et vous êtes à tapis.");
                                    jetonHero -= miseVilain - miseHero;
                                    pot = miseVilain * 2;
                                    miseHero = 0;
                                    miseVilain = 0;
                                    b = true;
                                }
                                else if (jetonHero < miseVilain - miseHero && miseVilain > 0)
                                {
                                    Console.WriteLine("\nVous misez le reste de vos jetons donc vous êtes à tapis.");
                                    tapisHero = jetonHero;
                                    jetonHero = 0;
                                    jetonVilain += miseVilain - jetonHero;
                                    pot = tapisHero * 2;
                                    miseHero = 0;
                                    miseVilain = 0;
                                    b = true;
                                }
                                break;
                            case 'f':
                                Console.WriteLine("\nTu fold.");
                                jetonVilain += pot;
                                f = true;
                                b = true;
                                break;
                        }
                    } while (!b);
                    if (p % 2 == 0)
                    {
                        // faire les choix de Vilain au BTN
                    }
                    else
                    {
                        // faire les choix de Vilain en BB
                    }
                } while (!f);
                f = false;
            }while(jetonHero != 0 || jetonVilain != 0);
        }
    }
}
