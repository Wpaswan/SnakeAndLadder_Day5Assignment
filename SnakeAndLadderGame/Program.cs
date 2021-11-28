using SnakeAndLadderGame;
Console.WriteLine("Please enter any key to start and n to stop");
char c = Convert.ToChar(Console.ReadLine());
while (c != 'n')
{
    Console.WriteLine("\t((((((((Please Selec Any          ))))))))");
    Console.WriteLine("\t((((((((1.Start With Zero         ))))))))");
    Console.WriteLine("\t((((((((2.Roll Dice               ))))))))");
    Console.WriteLine("\t((((((((3.Position of player      ))))))))");
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

          
    }
    Console.WriteLine("Please enter any key to start and n to stop");
    c = Convert.ToChar(Console.ReadLine());
}