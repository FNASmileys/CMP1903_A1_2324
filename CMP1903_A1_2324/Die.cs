using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        int currentRoll = 0;
        
        static Random rd = new Random();

        //Method
        public int Roll() 
        {
            currentRoll = rd.Next(1, 7);
            Console.WriteLine("the dice has been rolled and landed on " + currentRoll.ToString());
            return currentRoll;
        }


    }
}
