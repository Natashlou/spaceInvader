using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Space_Invaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Menu.ScreenSettings(20,50);
            m.DrawMenu(0, 2);

        }
    }
}
