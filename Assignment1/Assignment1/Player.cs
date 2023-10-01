using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Player
    {
        //  === C L A S S   V A R I A B L E S ===
        private const int maxCharInLine = 50;
        private int playerPos = 0;
        private int lives;
        private char color;


        //  === G E T T E R S / S E T T E R S ===
        // Position
        public int PlayerPos
        {
            get => playerPos;
            
            set
            {
                // handles invalid player position values
                if (value<2)
                    { playerPos = 2; }
                else if (value >= maxCharInLine)
                    { playerPos = maxCharInLine-1; }
                else
                    { playerPos = value; }
            }
        }

        // Lives
        public int Lives
        {
            get => lives;

            set
            {
                // handles invalid lives value
                if (value < 0 || value > 3)
                { lives = 1; }
                else
                { lives = value; }
            }
        }

        // Color
        public char Color
        {
            get => color;

            set
            {
                // handles invalid color inputs
                if ( value == 'R' || value == 'r' || value == 'G' || value == 'g' || value == 'B' || value == 'b')
                { color = value; }
                else
                { color = 'R'; }
            }
        }


        //   C O N S T R U C T O R S
        // Default Constructor
        public Player()
        {
            this.PlayerPos = maxCharInLine/2;
            this.Lives = 3;
            this.Color = 'R';
        }
        // Custom Constructor
        public Player(int lives, int playerPos, char color)
        {
            this.PlayerPos = playerPos;
            this.Lives = lives;
            this.Color = color;
        }


        //  === M E T H O D S ===

        // Controls
        public void MoveLeft()
        { 
            if (playerPos > 1)
            { playerPos--; }
        }
        public void MoveRight()
        {
            if (playerPos < maxCharInLine)
            { playerPos++; }
        }

        // State
        public char ChangeColor (char newColor)
        {
            this.Color = newColor;
            return this.Color;
        }
        public void Killed()
        {
            this.Lives--;
        }

        // Output
        public override string ToString()
        {
            string line = "";

            for (int i = 0; i < playerPos-1; i++)
            {
                line = line + "-";
            }
            line = line + lives + "^" + color;
            for (int i = 0; i < maxCharInLine-playerPos; i++)
            {
                line = line + "-";
            }
            return line;
        }




    }
}
