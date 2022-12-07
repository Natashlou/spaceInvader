using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Alien
    {
        //alien y = 3 x = 6
        public int x = 0;
        public int y = 0;
        string[] alien = new string[7]{"               ",
                                       "  ▀▄       ▄▀  ",
                                       "   ▄█▀███▀█▄   ",
                                       "  █▀███████▀█  ",
                                       " █  █▀▀▀▀▀█  █ ",
                                       "    ▀▀   ▀▀    ",
                                       "               "};
        public Alien(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            
            for(int i = 0; i <6; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write(alien[i]);
            }
        }

        public static void ScreenSettings()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 110;
        }
    }
}
