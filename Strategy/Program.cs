using Strategy;

if (args.Length != 2)
{
    Console.WriteLine("Usage: コマンドライン引数(randomseed1 randomseed2)");
    Console.WriteLine("Example:314 15");
    Console.ReadLine();
    return;
}

var seed1 = int.Parse(args[0]);
var seed2 = int.Parse(args[1]);
var player1 = new Player("Taro", new RandomStrategy(seed1));
var player2 = new Player("Hana", new ProbStrategy(seed2));

for (var i = 0; i < 10000; i++)
{
    var nextHand1 = player1.NextHand();
    var nextHand2 = player2.NextHand();
    if (nextHand1.IsStrongerThan(nextHand2))
    {
        Console.WriteLine("Winner:" + player1);
        player1.Win();
        player2.Lose();
    }
    else if (nextHand1.IsWeakerThan(nextHand2))
    {
        Console.WriteLine("Winner:" + player2);
        player2.Win();
        player1.Lose();
    }
    else
    {
        Console.WriteLine("Even...");
        player1.Even();
        player2.Even();
    }

    Console.WriteLine("Toral result:");
    Console.WriteLine(player1);
    Console.WriteLine(player2);


}

