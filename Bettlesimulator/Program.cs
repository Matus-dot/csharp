using Bettlesimulator;

namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin", 150, 3);

            while (true)
            {
                //Hero dostal utok od Monstra
                monster1.MonsterAttack(ourHero);

                //Monster dostal utok od hrdinu
                //monster1.HP = monster1.HP - ourHero.DMG;
                ourHero.HeroAttack(monster1);

                Console.WriteLine(ourHero.HP);
                Console.WriteLine(monster1.HP);

                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Hero is dead");
                    break;
                }

                if (monster1.HP <= 0)
                {
                    Console.WriteLine("Monster is dead");
                    break;
                }
            }
        }
    }
}