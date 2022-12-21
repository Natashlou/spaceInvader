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
        public int _x = 0;
        public int _y = 0;
        public int direction;
        string[] alien = new string[7]{"               ",
                                       "  ▀▄       ▄▀  ",
                                       "   ▄█▀███▀█▄   ",
                                       "  █▀███████▀█  ",
                                       " █  █▀▀▀▀▀█  █ ",
                                       "    ▀▀   ▀▀    ",
                                       "               "};
        public Alien(int x, int y)
        {
            _x = x;
            _y = y;
            direction = 1;
        }

        public void Draw()
        {
            for(int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(_x, _y+i);
                Console.Write(alien[i]);
            }
        }

        private void CheckDirection(int x)
        {
            if(x == 95)
            {
                _y += 7;
                direction = -1;
                _x += direction;
            }else if(x == 0 && _y != 0)
            {
                _y += 7;
                direction = 1;
                _x += direction;
            }
        }

        internal void Move()
        {
            CheckDirection(_x);
            //x = x + direction;
            _x += direction;
            
        }
    }
}
