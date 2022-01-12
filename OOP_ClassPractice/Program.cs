using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Player health: " + player.health);
            Console.WriteLine("Player lives: " + player.lives);
            Console.WriteLine("Player coordinates: " + player.x + "," + player.y);

            Enemy enemy = new Enemy();
            Console.WriteLine("Enemy health: " + enemy.health);
            Console.WriteLine("Enemy lives: " + enemy.lives);
            Console.WriteLine("Enemy coordinates: " + enemy.x + "," + player.y);

            Console.ReadKey(true);

            Mapper mapper = new Mapper();
            mapper.SetBounds();
            mapper.DisplayMap(2);

            player.Loop();
            Console.ReadKey(true);
            
        }
    }
}
