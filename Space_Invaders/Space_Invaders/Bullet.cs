using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Bullet
    {
        private int _position;
        private int _delay;

        public Bullet(int position, int delay)
        {
            _position = position;
            _delay = delay;
        }
    }
}
