using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Player
    {
        public int x = 0;
        public int y = 0;
        string[] ship = new string[7]{"                 ",
                                      "        ▄        ",
                                      "       ███       ",
                                      "  ▄███████████▄  ",
                                      "  █████████████  ",
                                      "  █████████████  ",
                                      "                 "};
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
