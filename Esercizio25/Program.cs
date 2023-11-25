/*Change the previous application. Allow the user to input 2 numbers. 
 * Use the first number to Skip and the second number to Take. 
 * Now do the Sum, Average and total number of items calculations on that subset of items.*/

Random random = new Random();
var numbers = Enumerable.Range(0, 100).Select(i => random.NextDouble()*1000).ToList();
Console.WriteLine($"La somma iniziale è {numbers.Sum()}\n");
Console.WriteLine($"La media iniziale è {numbers.Average()}\n");
Console.WriteLine($"I numeri totali sono {numbers.Count()}\n");

Console.WriteLine($"Inserisci un numero compreso tra 0 e {numbers.Count}\n");
string a = Console.ReadLine();
int skipNumber = int.Parse(a);

Console.WriteLine($"\nInserisci un numero compreso tra 0 e {numbers.Count - skipNumber}\n");
string b = Console.ReadLine();
int takeNumber = int.Parse(b);

Console.WriteLine();

var result = numbers.Skip(skipNumber).Take(takeNumber);

Console.WriteLine($"La somma finale è {result.Sum()}\n");
Console.WriteLine($"La media finale è {result.Average()}\n");
Console.WriteLine($"Ora i numeri totali sono {result.Count()}");