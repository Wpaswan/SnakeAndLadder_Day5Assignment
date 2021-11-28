using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class RollDice
    {
        public void Dice_roll()
        {
            Console.WriteLine("Welcome to snake ladder Game");
            int Start_Position = 0;
            Random random = new Random();

            int Dice_No = random.Next(1, 7);
            Console.WriteLine("Player roll dice and dice no is :  " + "   " +Dice_No);
        }
    }
}
