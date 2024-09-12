using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstVoleC_
{
    class Entity
    {
        public string Name;
    }

    enum Guns
    {
        Scar,
        Shotgun,
        Heavysniper
    }

    class Enemy : Entity
    {
        public int hp;
        public int dmg;
        public Boolean Isliving;

        
        public Enemy(string name, int hp, Guns guns, Boolean IsLiving)
        {
            this.Name = name;
            this.hp = hp;
            switch (guns)
            {
                case Guns.Scar:
                    dmg = 35;
                    break;
                case Guns.Shotgun:
                    dmg = 97;
                    break;
                case Guns.Heavysniper:
                    dmg = 157;
                    break;
            }
            this.Isliving = IsLiving;
        }

       
        public enum Heals
        {
            Smallpot,
            Bigpot,
            Chugjug
        }

        public void Healing(Heals heals)
        {
            switch (heals)
            {
                case Heals.Smallpot:
                    this.hp += 25;
                    break;
                case Heals.Bigpot:
                    this.hp += 50;
                    break;
                case Heals.Chugjug:
                    this.hp += 100;
                    break;
            }
        }

      
        Random random = new Random();

      
        public void Attack(Enemy enemy)
        {
          
            int crit = random.Next(1, 3); 
            int attackDamage = this.dmg * crit;
            if (enemy.hp < 0) {
            
            }
            else { 
            if (enemy.hp > 0)
            {
                enemy.Isliving = true;
                Console.WriteLine($"{this.Name} ubira {attackDamage} dmg  {enemy.Name}. Zbyvajici zivoty: {enemy.hp}.");
            }
            else if (enemy.hp <= 0)
            {
                enemy.Isliving = false;
                enemy.hp = 0;
                Console.WriteLine($"{this.Name} dava {attackDamage} dmg a zabiji {enemy.Name}.");
                
            }
                  }

            Console.WriteLine($"Crit: {crit}");

          
            enemy.hp -= attackDamage;

            
            
        }

       
        public override string ToString()
        {
            string obj = $"Name: {this.Name}, hp: {this.hp}, dmg:{this.dmg}, Isliving: {this.Isliving}";
            return obj;
        }
    }
}
