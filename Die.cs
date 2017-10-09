using System;

namespace DiceApp
{
    class Die
    {
        private int sides;
        private Random rng = new Random();

        public Die(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            int rolledNumber = rng.Next(1,sides+1);
            Console.WriteLine("Rolled a {0}", rolledNumber);
            return rolledNumber;
        }
    }
}
