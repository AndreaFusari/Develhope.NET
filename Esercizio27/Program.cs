/*Create a console application that checks whether all elements in a list of integers 
 * meet a specific condition (e.g., are even)
 * and whether any elements meet another condition (e.g., are odd) using LINQ.*/
Random random = new Random();
var numbers = Enumerable.Range(0,10).Select(i => random.Next(0,11)).ToList();
numbers.ForEach(Console.WriteLine);

var allNumbersAreEven = numbers.All(i=> i % 2 == 0);
var anyNumbersAreOdd = numbers.Any(i=> i % 2 != 0);

Console.WriteLine($"Are all numbers even? {allNumbersAreEven}");
Console.WriteLine($"Are any numbers odd? {anyNumbersAreOdd}");
