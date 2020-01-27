using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Hero
    {
        int maxHp;
        int hp;
        int def;
        int dmg;
        string name;

        public Hero(int _hp, int _def, int _dmg, string _name)
        {
            hp = _hp;
            maxHp = _hp;
            def = _def;
            dmg = _dmg;
            name = _name;
        }

        public static void Attack(Hero attacker, Hero defender)
        {
            defender.hp -= attacker.GetDmg() / defender.def;
        }

        public virtual void Practice()
        {
            maxHp++;
            hp++;
            def++;
            dmg++;
        }

        public virtual int GetDmg()
        {
            return dmg;
        }

        public virtual void Heal()
        {
            hp = maxHp;
        }

        public virtual void PrintStats()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hp: " + hp + "/" + maxHp);
            Console.WriteLine("Def: " + def);
            Console.WriteLine("Dmg: " + dmg);
        }
    }
}
