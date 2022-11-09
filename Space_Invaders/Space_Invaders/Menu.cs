using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Menu
    {
        
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
            
                
        }
    }
}
