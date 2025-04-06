using BetterRandom;

string? QuestionAwnser = @"
I think it would be better to use the extentions.
You don't have to make a new instance of a random.
It really allows people to add methods to your class withought having to go find the where the class is defined and add the method to it.
";

Random random = new Random();
Console.WriteLine(random.NextDouble(10));
Console.WriteLine(random.NextString("The","quick","brown","fox","jumps","over","the","lazy","dog."));
Console.WriteLine(random.CoinFlip());

Console.WriteLine(QuestionAwnser);