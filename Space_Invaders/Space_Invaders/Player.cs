using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Player
    {
        public int _x;
        public int _y;
        string[] ship = new string[7]{"                 ",
                                      "        ▄        ",
                                      "       ███       ",
                                      "  ▄███████████▄  ",
                                      "  █████████████  ",
                                      "  █████████████  ",
                                      "                 "};
        public Player(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void DrawPlayer()
        {
            if (_x < 0)
            {
                _x = 0;
            }
            else if (_x > 93)
            {
                _x = 93;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(_x, _y + i);
                Console.Write(ship[i]);
            }
            Move();
        }

        internal void Move()
        {
            if (Console.KeyAvailable)
            {

                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.LeftArrow)
                {
                    _x--;
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    _x++;
                }
            }

        }
    }
}
