// Create a program, prompt the user for a file path.
// Then the program should read that file and print out the contents of that file.
// What happens when you point it to a text file?
// What happens when you point it to the PowerPoint file for this unit?
// Bonus points: make it work for both absolute and relative paths.
using System.Threading.Channels;

Console.WriteLine($"Questa è la directory corrente {Directory.GetCurrentDirectory()}");
Console.WriteLine("Inserisci il percorso del file da aprire");
string filePath = Console.ReadLine();
try
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("File non trovato");
}
catch (Exception ex)     
{
    Console.WriteLine(ex.StackTrace);
}
