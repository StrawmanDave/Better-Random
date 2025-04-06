# Better-Random
This is for the Challenge Better Random out of the C# Players Guide Fifth Edition on page 278.

Better Random Page 278
Random.NextDouble() only returns values between 0 and 1, and they often need to be able to produce random double values between 0 and another number such as 0 and 10.
They need to randomly choos from one of several strings, such as "up", "down", "left", and "right", witch each having an equal probability of being chosen.
They need to do a coint toss, random picking a bool, and usually want it to be a fair coin toss(50% heads and 50% tails) but occasionally want unequal probabilities.
For example, a 75% chance of true and a 25% chance of false.
Objectives
Create a new static class to add extension methods for Random.
As described above, add a NextDouble extension method that gives a maximum value for a random generated double.
Add a NextString extension method for Random that allows you to pass in any number of string values (using params) and randomly pick one of them.
Add a CoinFlip method that randomly picks a bool value. It should have an option parameter that indicates the frequency of heads coming up,
wich should default to 0.5 or 50% of the time
Answer this question: In your opinion, would it be better to make a derived AdvnacedRandom class that adds these methods or use extension methods and why?