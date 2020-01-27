using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Magic : Hero
    {
        int maxMana;
        int mana;
        string spellType;

        public Magic(int _mana, string _spellType, int _hp, int _def, int _dmg, string _name) : base(_hp, _def, _dmg, _name)
        {
            mana = _mana;
            maxMana = _mana;
            spellType = _spellType;
        }

        public override void Practice()
        {
            base.Practice();
            mana++;
            maxMana++;
        }

        public override int GetDmg()
        {
            mana--;

            if (mana > 0)
                return base.GetDmg();
            else
                return 0;

        }

        public override void Heal()
        {
            base.Heal();
            mana = maxMana;
        }

        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine("Type: Magic");
            Console.WriteLine("Mana: " + mana + "/" + maxMana);
            Console.WriteLine("Spell type: " + spellType);
        }
    }
}
