using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Melee : Hero
    {
        int maxStamina;
        int stamina;
        string weapon;

        public Melee(int _stamina, string _weapon, int _hp, int _def, int _dmg, string _name) : base(_hp, _def, _dmg, _name)
        {
            stamina = _stamina;
            maxStamina = _stamina;
            weapon = _weapon;
        }

        public override void Practice()
        {
            base.Practice();
            stamina++;
        }

        public override int GetDmg()
        {
            stamina--;

            if (stamina > 0)
                return base.GetDmg();
            else
                return 0;

        }

        public override void Heal()
        {
            base.Heal();
            stamina = maxStamina;
        }

        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine("Type: Melee");
            Console.WriteLine("Stamina: " + stamina + "/" + maxStamina);
            Console.WriteLine("Weapon: " + weapon);
        }
    }
}
