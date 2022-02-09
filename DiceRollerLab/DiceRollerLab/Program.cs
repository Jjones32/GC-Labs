using System;

namespace DiceRollerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("How many sides would you like each die to have?");
                int sides = Convert.ToInt32(Console.ReadLine());

                roll(sides);

                Console.WriteLine("Would you like to restart? (y/n)");
                var userAnswr = Console.ReadLine().ToLower();
                if (userAnswr == "n")
                {
                    break;
                }
            }
            while (true); 

            

               

             
        }
        public static void roll(int sides)
        {
            Random random = new Random();
            int dice_1 = random.Next(1, sides);
            int dice_2 = random.Next(1, sides);
            if (sides == 6)
            {
                SixSideDie(dice_1, dice_2);
            }
            Console.WriteLine("dice 1 = " + dice_1 + " dice 2 = " + dice_2 + Environment.NewLine);
        }
        public static void SixSideDie(int dieOne, int dieTwo)
        {
            int sum = dieOne + dieTwo;
            if (dieOne == 1 && dieTwo == 1)
            {
                Console.WriteLine("You rolled SNake Eyes!");
            }
            if (dieOne == 1 && dieTwo == 2 || dieOne == 2 && dieTwo == 1)
            {
                Console.WriteLine("You have rolled an Ace Deuce!");
            }
            if (dieOne == 6 && dieTwo == 6)
            {
                Console.WriteLine("You rolled Box Cars!");
            }
            if (sum == 7 || sum == 11)
            {
                Console.WriteLine("You WIN!");
            }
            if (sum == 2 || sum == 3 || sum == 12)
            {
                Console.WriteLine("You have rolled Craps!");
            }
            

            
        }
    }
}
