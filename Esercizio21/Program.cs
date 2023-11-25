/*Change the previous application to use LINQ's method syntax instead.*/

Random random = new Random();

var numbers = Enumerable.Range(0, 1000).Select(n => random.Next(0, 1001));

var oddNumbers = numbers.Where(n=> n % 2 != 0).OrderBy(n=>n);

foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}

