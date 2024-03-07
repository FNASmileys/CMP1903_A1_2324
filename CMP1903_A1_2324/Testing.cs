using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Testing {
    /*
     * This class should test the Game and the Die class.
     * Create a Game object, call the methods and compare their output to expected output.
     * Create a Die object and call its method.
     * Use debug.assert() to make the comparisons and tests.
     */

    //Method

    public void Test() {
      //runs an object of the Game method and checks wheather it is within the expected bounds and if not gives an error message
      Game game = new Game();
      Debug.Assert(game.Play() >= 3 && game.Play() <= 18, "Error: Game method returned a number outside expected bounds");

      //runs an object of the Die method and checks wheather it is within the expected bounds and if not gives an error message
      Die die = new Die();
      Debug.Assert(die.Roll() >= 1 && die.Roll() <= 6, "Error: Die method returned a number outside expected bounds");
    }
  }
}
