using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Invaders!\nUse the L and R keys to move Left and Right.\nChange colors by using the R, G, or B keys.\nYou can simulate being hit with the X key.\nYou can quit at any time with the Q or S keys.\n\n");

            Player player = new Player();

            
            
            while (player.Lives > 0) 
            {
                // Output
                Console.Write("\r" + player.ToString());
                
               // Input handling 
                char keypressed = Console.ReadKey(true).KeyChar;
                
                if (keypressed =='L' || keypressed =='l')
                {
                    player.MoveLeft();
                }
                else if (keypressed == 'R' || keypressed == 'r')
                {
                    player.MoveRight();
                }
                else if (keypressed == 'Q' || keypressed == 'q' || keypressed == 'S' || keypressed == 's')
                {
                    break;
                }
                else if (keypressed == 'R' || keypressed == 'r' || keypressed == 'G' || keypressed == 'g' || keypressed == 'B' || keypressed == 'b')
                {
                    player.ChangeColor(keypressed);
                }
                else if (keypressed == 'X' || keypressed == 'x')
                {
                    player.Killed();
                }
            }
            Console.Write("\r" + player.ToString() + "\n\n");
            
            // Game over and exit
            if (player.Lives == 0)
            {
                Console.WriteLine("Game Over!\nThanks for playing!\nPress any key to quit.");
                Console.ReadKey();
            }
            
        }
    }
}
