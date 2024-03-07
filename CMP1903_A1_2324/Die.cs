using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Die {
    /*
     * The Die class should contain one property to hold the current die value,
     * and one method that rolls the die, returns and integer and takes no parameters.
     */

    //Property
    private int _currentRoll = 0;

    static private Random rand = new Random();

    //Method
    //generates and returns the dice roll
    public int Roll() {
      _currentRoll = rand.Next(1, 7);
      //returns the result of each dice roll this method performs
      Console.WriteLine("the dice has been rolled and landed on " + _currentRoll.ToString());
      return _currentRoll;
    }
  }
}
