using System;
using System.Collections.Generic;

namespace DiceApp
{
    class Cup
    {
        private List<Die> Dice = new List<Die>();

        public Cup()
        {}

        public void AddDice(Die die)
        {
            Dice.Add(die);
        }

        public int RollDice()
        {
            int total = 0;
            foreach(Die die in Dice)
            {
                total += die.Roll();
            }

            return total;
        }
    }
}
