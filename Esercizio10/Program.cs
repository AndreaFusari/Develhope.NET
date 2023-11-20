/*Create a console application. The console application should ask the user 10 times for input. 
 * This input is added to a list. After the 10th time, the console program will print out the list twice. 
 * Once from start to finish, the other time in reverse.
 * Tip: If you find yourself writing Console.ReadLine() 10 times, maybe there's a smarter way to do this?*/
int i = 0;
List<string> list = new List<string>();

while (i < 10)
{
    Console.WriteLine("Inserisci un valore");
    string value = Console.ReadLine();
    list.Add(value);
    i++;
}
Console.WriteLine("Lista originale: ");

foreach (string value in list)
{
        Console.Write($"{value}, ");
}
Console.WriteLine();
Console.WriteLine("Lista inversa:");

for (int j = list.Count - 1; j >= 0; j--)
{
    if (j == 0)
        Console.WriteLine(list[j]);
    else 
        Console.Write($"{list[j]}, ");
}