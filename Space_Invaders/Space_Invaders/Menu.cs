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
        private bool enter;
        public Menu()
        {
            
        } 

        public void DrawMenu(int x, int y)
        {
            Console.Clear();
            Console.WriteLine("Space Invaders\n");
            Console.WriteLine("   Play");
            Console.WriteLine("   help");
            Console.WriteLine("   Scores");
            Console.WriteLine("   Settings-Exit");
            Console.SetCursorPosition(x, y);
            Console.Write("->");
            ConsoleKey key = Console.ReadKey().Key;
            UpOrDown(key);
        }

        public void DrawMenuHelp()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                    ║  ║  ╔══  ║    ╔══╗                     ");
            Console.WriteLine("                    ╠══╣  ╠══  ║    ╠══╝                     ");
            Console.WriteLine("                    ║  ║  ╚══  ╚══  ║                        ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("The goal of the game is to kill all the aliens that are above\nyour space ship, you will have 3 lives to complet the goal.\n");
            Console.WriteLine("to move left or right in game press either the left arrow or \nthe right one.\n");
            Console.WriteLine("Press space in game to shoot your bullets.\n");
            Console.WriteLine("Press esc in game to access the pause menu, where you can then\n[Return to the game] , [access the settings] or [Exit the game].\n");
            Console.WriteLine("Have fun!\n");
            Console.WriteLine("-> Exit");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                DrawMenu(x, y);
            }
                
        }
        public void UpOrDown(ConsoleKey key)
        {
            while (key != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.DownArrow && y < 5)
                {
                    y++;
                    DrawMenu(x, y);
                }
                else if (key == ConsoleKey.UpArrow && y > 2)
                {
                    y--;
                    DrawMenu(x, y);
                }
                else
                {
                    DrawMenu(x, y);
                }
                enter = true;
                break;
            }

            if (enter == true && y == 3)
            {
                DrawMenuHelp();
            }
            else if(enter == true && y == 5)
            {
                
            }
        }
    }
}
