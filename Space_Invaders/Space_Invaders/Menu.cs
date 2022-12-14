using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        public static void GameScreenSettings()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 110;
        }

        public static void MenuScreenSettings()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 50;
        }
        public void IntroduceFleet()
        {
            Console.Clear();
            string line = "Hello! congrats on finding the secret key to my game!\n";
            string line1 = "I made this game for a school projet and I had to add somthing original so here it is.\n";
            string line2 = "this does not have any impact on the game, it's just for fun :D\n";
            string control = "Press any key to exit!\n";

            Console.SetCursorPosition(5, 6);
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(60);
            }
            Console.SetCursorPosition(5, 8);
            for (int i = 0; i < line1.Length; i++)
            {
                Console.Write(line1[i]);
                Thread.Sleep(60);
            }
            Console.SetCursorPosition(5, 10);
            for (int i = 0; i < line2.Length; i++)
            {
                Console.Write(line2[i]);
                Thread.Sleep(60);
            }
            Console.SetCursorPosition(5, 12);
            for (int i = 0; i < control.Length; i++)
            {
                Console.Write(control[i]);
                Thread.Sleep(60);
            }
            Console.SetCursorPosition(5, 13);
            Console.ReadKey();
            DrawMenu(x, y);
            Thread.Sleep(1000);
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
            /*
             * numbers meaning
             * 2. Play
             * 3. Help
             * 4. Scores
             * 5. Settings/Exit 
             */

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
                else if (key == ConsoleKey.N)
                {
                    IntroduceFleet();
                }
                else if (key == ConsoleKey.UpArrow && y == 2)
                {
                    DrawMenu(x, y);
                }
                else if (key == ConsoleKey.DownArrow && y == 5)
                {
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
            else if (enter == true && y == 5)
            {

            }
            else if (enter == true && y == 2)
            {
                Console.Clear();
                GameScreenSettings();
                Alien a = new Alien(1, 1);
                Lives l = new Lives(3);
                l.setLives(1);
                List<Alien> aliens = new List<Alien>();
                aliens.Add(a);
                aliens.Add(new Alien(16, 1));
                aliens.Add(new Alien(31, 1));
                while (l.GetLives != 3)
                {
                    //update model
                    foreach(Alien alien in aliens)
                    {
                        alien.Move();
                    }
                    //render
                    foreach (Alien alien in aliens)
                    {
                        alien.Draw();
                    }

                    //timing
                    
                    Thread.Sleep(100);
                }

                Console.Read();
            }
        }
    }
}
