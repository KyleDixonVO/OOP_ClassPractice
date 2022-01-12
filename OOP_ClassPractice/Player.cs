using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassPractice
{
    class Player
    {
        public int x = 10;
        public int y = 10;
        public int health = 42;
        public int lives = 3;
        public bool movementEnabled = true;
        public ConsoleKey input;
        public void Move()
        {
            input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.W)
            {
                y--;
            }
            if (input == ConsoleKey.S)
            {
                y++;
            }
            if (input == ConsoleKey.A)
            {
                x--;
            }
            if (input == ConsoleKey.D)
            {
                x++;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write('@');
        }

        public void Loop()
        {
            while (movementEnabled == true)
            {
                Move();
                Draw();
            }
        }
    }
}
