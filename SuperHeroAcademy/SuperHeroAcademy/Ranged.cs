using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Ranged : Hero
    {
        int ammo;
        string effect;

        public Ranged(int _ammo, string _effect, int _hp, int _def, int _dmg, string _name) : base(_hp, _def, _dmg, _name)
        {
            ammo = _ammo;
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
    }
}
