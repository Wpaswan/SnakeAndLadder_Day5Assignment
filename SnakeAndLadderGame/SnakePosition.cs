﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class SnakePosition
    {
        public void pos_Snake()
        {
            Console.WriteLine("Welcome to snake ladder Game");
            int Start_Position = 0;
            int Current_Position = 0;
            int Winning_Position = 100;

            Random random = new Random();


            while (Current_Position <= 100)
            {
                int Dice_No = random.Next(1, 7);
                int Player_Choice = random.Next(1, 4);
                Console.WriteLine("Player roll dice and dice no is :  " + "   " + Dice_No);

                switch (Player_Choice)
                {
                    ///
                    ///  we using 1 for no play
                    ///
                    case 1:
                        Console.WriteLine("Player is not playing ");
                        Current_Position += 0;
                        Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                        break;

                    //
                    // we using 2 for ladder 
                    //

                    case 2:
                        Console.WriteLine("player is go for ladder");
                        Current_Position =Current_Position+ Dice_No;
                        Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                        break;

                    //
                    // we are using 3 for sanke point 
                    //
                    case 3:
                        Console.WriteLine("Player go for Snake point ");
                        Current_Position = Current_Position - Dice_No;

                        //
                        // logic applied for if current postion go below 0  and set current position as 0
                        //
                        if (Current_Position < 0)
                        {
                            Console.WriteLine("curreint position going below  0  ");
                            Current_Position = 0;
                            Console.WriteLine("Current position defaltly set as 0 :" + "  " + Current_Position);
                        }


                        Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                        break;
                }
            }
        }
    }
}
