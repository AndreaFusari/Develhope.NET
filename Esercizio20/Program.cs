/*Create a console application that filters a list of integers. 
 * It should only select uneven numbers from a list of 1000 random integers. 
 * Use LINQ's query syntax to solve this exercise.*/

Random random = new Random();
var numbers = Enumerable.Range(0,1000).Select(x => random.Next(0,1001)).ToList();

var oddNumbers = from number in numbers
                 where number % 2 != 0
                 orderby number
                 select number;

Console.WriteLine("Lista di numberi dispari:");
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}