using System;

namespace DiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Die d4 = new Die(4);
            Die d6 = new Die(6);
            Die d8 = new Die(8);
            Die d10 = new Die(10);
            Die d12 = new Die(12);
            Die d20 = new Die(20);
            
            Cup cup = new Cup();

            bool addMore = false;
            do
            {
                Console.WriteLine("How many sides? 4, 6, 8, 10, 12, 20");

                
                int numSides = Convert.ToInt32(Console.ReadLine());
                switch(numSides)
                {
                    case 4: cup.AddDice(d4); break;
                    case 6: cup.AddDice(d6); break;
                    case 8: cup.AddDice(d8); break;
                    case 10: cup.AddDice(d10); break;
                    case 12: cup.AddDice(d12); break;
                    case 20: cup.AddDice(d20); break;
                    default: Console.WriteLine("Not a valid option"); break;
                }

                Console.WriteLine("Add more?");
                if(Console.ReadLine() == "Y")
                {addMore = true;}
                else
                {addMore = false;}

            } while(addMore);

            Console.WriteLine("Total: {0}", cup.RollDice());

            Console.ReadLine();


        }
    }
}
