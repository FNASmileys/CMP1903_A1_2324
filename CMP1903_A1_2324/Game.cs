using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Game {
    /*
     * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
     *
     * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
     * rolls could be continous, and the totals and other statistics could be summarised for example.
     */

    //Methods

    // defines the array that the objects of the Die class will be initialised into 
    private Die[] _dice = new Die[3];

    //runs when Game is initialised as an object
    public Game() {
      // initialises the Die method as objects in an array
      for (int i = 0; i < _dice.Count(); i++) {
        _dice[i] = new Die();
      }
    }

    //adds results of the dice roll together
    public int Play() {
      int sum = _dice[0].Roll() + _dice[1].Roll() + _dice[2].Roll();
      return sum;
    }
  }
}
