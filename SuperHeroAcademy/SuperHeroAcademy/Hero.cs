using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Hero
    {
        protected int hp;
        public int def { get; private set; }
        int dmg;
        string name;

        public Hero(int _hp, int _def, int _dmg, string _name)
        {
            hp = _hp;
            def = _def;
            dmg = _dmg;
            name = _name;
        }

        public static void Attack(Hero attacker, Hero defender)
        {
            defender.hp = attacker.GetDmg() / defender.def;
        }

        public virtual void Practice()
        {
            hp++;
            def++;
            dmg++;
        }

        public virtual int GetDmg()
        {
            return dmg;
        }

        public void PrintStats()
        {
            Console.WriteLine(name);
            Console.WriteLine(hp);
            Console.WriteLine(def);
            Console.WriteLine(dmg);
        }
    }
}
