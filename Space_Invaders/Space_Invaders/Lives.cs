using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Lives
    {
        private int _number, _maxLives;

        public Lives(int maxLives)
        {
            _maxLives = maxLives;
        }

        public void setLives(int number)
        {
            _number = number;
        }
        public int GetLives
        {
            get { return _number; }
        }
    }
}
