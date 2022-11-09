using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Invaders
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 2;
            
            Menu m = new Menu();
            m.DrawMenu(x, y);
            ConsoleKey key = Console.ReadKey().Key;

            while (key != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.DownArrow && y != 5)
                {
                    
                    Console.Clear();
                    y = y + 1;
                    m.DrawMenu(x, y);
                }
                else if (key == ConsoleKey.UpArrow && y != 2)
                {
                    Console.Clear();
                    y = y - 1;
                    m.DrawMenu(x, y);
                }
            } 

        }
    }
}
