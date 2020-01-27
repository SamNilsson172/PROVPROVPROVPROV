using System;

namespace SuperHeroAcademy
{
    class Program
    {
        static Magic magic()
        {
            string name = TheGoodStuff.String(2, 16, false, "Name you hero");
            return new Magic(10, null, 70, 5, 25, name);
        }

        static Melee melee()
        {
            string name = TheGoodStuff.String(2, 16, false, "Name you hero");
            return new Melee(10, null, 110, 7, 15, name);
        }

        static Ranged ranged()
        {
            string name = TheGoodStuff.String(2, 16, false, "Name you hero");
            return new Ranged(10, null, 90, 6, 20, name);
        }

        static void Main(string[] args)
        {
            Hero yourHero;

            string[] heroTypes = { "Magic", "Melee", "Ranged" };
            int selected = TheGoodStuff.Selection(heroTypes, "What type of hero would you like to be?", 1);
            switch (selected)
            {
                case 0:
                    yourHero = magic();
                    break;

                case 1:
                    yourHero = melee();
                    break;

                case 2:
                    yourHero = ranged();
                    break;

                default:
                    yourHero = null;
                    break;
            }

            yourHero.PrintStats();

        }
    }
}
