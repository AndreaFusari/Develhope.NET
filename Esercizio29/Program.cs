/*Create a list of 100 random numbers. For every number, create an instance of the new class NumberMetaData. 
 * The class should contain the following properties: 
 * IsEven, NumberOfCharacters. 
 * Try using Select() in LINQ to transform 100 numbers into 100 instances of NumberMetaData
 */

using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

Random random = new Random();
var numbers = Enumerable.Range(0, 100).Select(i => random.Next(0, 101)).ToList();

var result = numbers.Select(n=> new NumberMetaData(n));

foreach (var item in result)
{
    Console.WriteLine(item+"\n");
}

internal class NumberMetaData
{
    public int Number { get; }
    public bool IsEven { get; }
    public int NumberOfCharacters { get; }

    public NumberMetaData(int number)
    {
        if (number % 2 == 0)
        {
            IsEven = true;
        }
        else IsEven = false;

        NumberOfCharacters = number.ToString().Length;
        Number = number;
       
    }
    public override string ToString()
    {
        return $"{Number} -> Is Even({IsEven})  Number of character({NumberOfCharacters})";
    }
}