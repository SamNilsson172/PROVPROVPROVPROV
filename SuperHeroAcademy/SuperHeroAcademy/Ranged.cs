using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Ranged : Hero
    {
        int maxAmmo;
        int ammo;
        string effect;

        public Ranged(int _ammo, string _effect, int _hp, int _def, int _dmg, string _name) : base(_hp, _def, _dmg, _name)
        {
            ammo = _ammo;
            maxAmmo = _ammo;
            effect = _effect;
        }

        public override void Practice()
        {
            base.Practice();
            ammo++;
        }

        public override int GetDmg()
        {
            ammo--;

            if (ammo > 0)
                return base.GetDmg();
            else
                return 0;

        }

        public override void Heal()
        {
            base.Heal();
            ammo = maxAmmo;
        }

        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine("Type: Ranged");
            Console.WriteLine("Mana: " + ammo + "/" + maxAmmo);
            Console.WriteLine("Effect: " + effect);
        }
    }
}
