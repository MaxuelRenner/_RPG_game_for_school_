using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character wizzard = new Character(65, 30, "wizzard", 20);
            Character knight = new Character(80,20,"knight",10);
            Character elf = new Character(60, 25, "Elf", 15);

            List<Character> Hero = new List<Character>();
            Hero.Add(wizzard);
            Hero.Add(knight);
            Hero.Add(elf);


            Enemy FirstEnemy = new Enemy(50, 10);

            Weapon Sword = new Weapon(5,"Mele");
            Weapon Bow = new Weapon(10,"Range");
            Weapon Galangal = new Weapon(15,"Range"); 

            wizzard.beingHit(FirstEnemy.Enemydmg);
            knight.beingHit(FirstEnemy.Enemydmg);
            elf.beingHit(FirstEnemy.Enemydmg);

            knight.Addwepdmg(Sword.Weapondmg);
            elf.Addwepdmg(Bow.Weapondmg);
            wizzard.Addwepdmg(Galangal.Weapondmg);

            FirstEnemy.EnemyBeingHit(wizzard.dmg);
            FirstEnemy.EnemyBeingHit(knight.dmg);
            FirstEnemy.EnemyBeingHit(elf.dmg);



          

            Console.WriteLine("Chose a character:");
            Console.WriteLine("1.Wizzard");
            Console.WriteLine("2.Knight");
            Console.WriteLine("3.Elf");

            string a=Console.ReadLine();

            if (a == "wizzard" || a == "Wizzard" || a == "1")
            {
                Console.WriteLine("You have chosen the Wizzard.");
              Hero.
            }

            if (a == "knight" || a == "Knight" || a == "2")
            {
                Console.WriteLine("You have chosen the Knight.");
                Console.WriteLine(knight);
            }

            if (a == "Elf" || a == "elf" || a == "3")
            {
                Console.WriteLine("You have chosen the Elf.");
                Console.WriteLine(elf);
            }

            Console.WriteLine("You run into an enemy!");
            Console.WriteLine("Chose between heal and attack!");
            string b = Console.ReadLine();

            while (FirstEnemy.Enemyhp > 0)
            {

                if (b == "Heal" || b == "heal")
                {
                    wizzard.Heal();
                    knight.Heal();
                    elf.Heal();
                    Console.WriteLine("You healed for about: "+wizzard.hp+"hp");
                    Console.WriteLine("You healed for about: "+knight.hp + "hp");
                    Console.WriteLine("You healed for about: "+elf.hp + "hp");

                }

                else if  (b == "Attack" || b == "attack")
                {
                    FirstEnemy.EnemyBeingHit(wizzard.dmg);
                    FirstEnemy.EnemyBeingHit(knight.dmg);
                    FirstEnemy.EnemyBeingHit(elf.dmg);
                    Console.WriteLine("The enemy has left:"+FirstEnemy.Enemyhp+"hp!");
                }


            }



            Console.ReadLine();
            Console.Read();
        }
    }
}
