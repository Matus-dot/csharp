using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bettlesimulator;

namespace Cvicenie_BattleSimulator
{
    public class Monster
    {
        public string RaceType { get; set; } //Monster RaceType (e.g ... Goblin,Orc,Troll)
        public int HP { get; set; }
        public int DMG { get; set; }

        public Monster(string raceType, int hP, int dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }
        public void MonsterAttack(Hero hero)
        {
            hero.HP = hero.HP - DMG;
        }
    }
}