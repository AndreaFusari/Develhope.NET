/*Create another list of 1000 random integers. 
 * Can you sort them from low to high? Print out the result.
 * Bonus points if you can do it in reverse too.*/
Random random = new Random();

var ascNumbers = Enumerable.Range(0, 1000).Select(n => random.Next(0,1001)).OrderBy(n=>n);

var descNumbers = ascNumbers.OrderByDescending(n=>n);

Console.WriteLine("Ascending Order: ");
foreach (var asc in ascNumbers)
{
    Console.WriteLine(asc);
}
Console.WriteLine("Descending Order: ");
foreach (var desc in descNumbers)
{
    Console.WriteLine(desc);
}

