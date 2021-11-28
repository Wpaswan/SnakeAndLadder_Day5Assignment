using SnakeAndLadderGame;
Console.WriteLine("Please enter any key to start and n to stop");
char c = Convert.ToChar(Console.ReadLine());
while (c != 'n')
{
    Console.WriteLine("\t((((((((Please Selec Any          ))))))))");
    Console.WriteLine("\t((((((((1.Start With Zero         ))))))))");
    Console.WriteLine("\t((((((((2.Roll Dice               ))))))))");
    Console.WriteLine("\t((((((((3.Position of player      ))))))))");
    Console.WriteLine("\t((((((((4.Position of snaek       ))))))))");
    Console.WriteLine("\t((((((((5.Winning positon 100     ))))))))");
    Console.WriteLine("\t((((((((6.Number of time dice roll))))))))");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            StartPositionZero sp = new StartPositionZero();
            sp.Startzero();
            break;
            case 2:
            RollDice rd=new RollDice();
            rd.Dice_roll();
            break;
        case 3:
            PlayerPosition pp=new PlayerPosition();
            pp.position();
            break;
        case 4:
            SnakePosition sp1=new SnakePosition();
            sp1.pos_Snake();
            break;
        case 5:
            WinningPosition100 w=new WinningPosition100();
            w.win_pos();
            break;
        case 6:
            Num_Of_Time_DiceRolled obj=new Num_Of_Time_DiceRolled();
            obj.DiceCount();
            break;

          
    }
    Console.WriteLine("Please enter any key to start and n to stop");
    c = Convert.ToChar(Console.ReadLine());
}