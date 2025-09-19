using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalHeroes
{
    public static class UITools
    {
        public static void PrintDigitalHeroesLogo()
        {
            string[] shield = new string[]
            {
            "            ###########            ",
            "         #################         ",
            "       #####################       ",
            "     #########################     ",
            "    ####                   ####    ",
            "   ####     DDDDDD   H   H   ###   ",
            "  ####      D     D  H   H    ###  ",
            "  ###       D     D  HHHHH    ###  ",
            "  ###       D     D  H   H    ###  ",
            "  ####      DDDDDD   H   H   ####  ",
            "   ####                   ####     ",
            "     #########################     ",
            "       #####################       ",
            "         #################         ",
            "            ###########            "
            };

            for (int i = 0; i < shield.Length; i++)
            {
                foreach (char c in shield[i])
                {
                    if (c == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;   
                        Console.Write("█");
                    }
                    else if (c == 'D' || c == 'H')
                    {
                        Console.ForegroundColor=
                            ConsoleColor.White;  
                        Console.Write("█");
                    }
                    else if (c == ' ')
                    {
                         
                        Console.ForegroundColor = ConsoleColor.Black;  
                        Console.Write("█");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     D I G I T A L   H E R O E S");
            Console.WriteLine("          Les héros méconnus");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
