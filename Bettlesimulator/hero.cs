using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bettlesimulator
{
   
        public class Hero
    {
        public string Name { get; set; } = "Arnost";
        public int HP { get; set; } = 100;
        public int DMG { get; set; } = 10;

        public bool HeroAttack(Monster monster)
        {
            monster.HP = monster.HP - this.DMG;
        }
    }
}

