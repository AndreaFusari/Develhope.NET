/*Create an application that finds the Sum, Average and total number of items in a List of doubles.*/

Random random = new Random();   
var numbers = Enumerable.Range(0,100).Select(i => random.NextDouble()*100).ToList();

Console.WriteLine($"La somma è {numbers.Sum()}\n");
Console.WriteLine($"La media è {numbers.Average()}\n");
Console.WriteLine($"I numeri presenti nella lista sono {numbers.Count()}");

