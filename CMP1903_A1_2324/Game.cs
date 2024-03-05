using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();

        public int Play()
        {
            int Number1 = die1.Roll();
            int Number2 = die2.Roll();
            int Number3 = die3.Roll();

            int sum = Number1 + Number2 + Number3;
            
            ;
            return sum;
        }
    }
}
