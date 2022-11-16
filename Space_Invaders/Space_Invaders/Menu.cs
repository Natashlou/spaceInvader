using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Menu
    {
        private int x = 0;
        private int y = 2;
        public Menu()
        {
            
        } 

        public void DrawMenu(int x, int y)
        {
            Console.WriteLine("Space Invaders\n");
            Console.WriteLine("   Play");
            Console.WriteLine("   help");
            Console.WriteLine("   Scores");
            Console.WriteLine("   Settings-Exit");
            Console.SetCursorPosition(x, y);
            Console.Write("->");
        }

        public void UpOrDown(ConsoleKey key)
        {
            while (key != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.DownArrow && y < 5)
                {
                    Console.Clear();
                    y++;
                    DrawMenu(x, y);
                }
                else if (key == ConsoleKey.UpArrow && y > 2)
                {
                    Console.Clear();
                    y--;
                    DrawMenu(x, y);
                }
                else
                {
                    Console.Clear();
                    DrawMenu(x, y);
                }
                key = Console.ReadKey().Key;
            }
        }
    }
}
