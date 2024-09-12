using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVoleC_
{
     class Program
    {
        static void Main(string[] args)
        {
            Enemy michal = new Enemy("Michal", 200, Guns.Heavysniper, true);
            Enemy pepa = new Enemy("Pepa", 200, Guns.Heavysniper, true);
            michal.Attack(pepa);
            pepa.Attack(michal);
            michal.Attack(pepa);
            michal.Healing(Enemy.Heals.Smallpot);
            Console.WriteLine(michal);
            Console.WriteLine(pepa);
            
            Console.ReadLine();
        }
    }
}
