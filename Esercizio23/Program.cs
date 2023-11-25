/*Sorting numbers is easy, just go from low to high and you're done. 
 * But you can create your own way of sorting too. 
 * Can you combine LINQ with a Custom Comparer to sort items based on how many characters they have? 
 * For instance:
5 = 1 character
52 = 2 characters
364 = 3 characters
Create a list of 1000 random numbers, and sort it by the amount of characters each number has, 
from low to high.*/

using System.Collections.Immutable;

Random random = new Random();

var numbers = Enumerable.Range(0, 1000).Select(n => random.Next(0, 1001));

var sortedNumbers = numbers.OrderBy(n => n, new intComparer());

foreach (var number in sortedNumbers) 
{ 
    Console.WriteLine(number); 
}

//Custom Comparer
public class intComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        int xLength = x.ToString().Length;
        int yLength = y.ToString().Length;

        return xLength.CompareTo(yLength);
    }
}