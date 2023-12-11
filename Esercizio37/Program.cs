/*Create a program that writes user input to a file. 
 * Then read from that file and print the results. 
 * Make sure to use the Async() methods of the File class to do so.*/

await WriteToFile();
await ReadFromFile();
static async Task WriteToFile()
{
    Console.WriteLine("Inserisci qualcosa da scrivere nel file: ");
    string text = Console.ReadLine();

    await File.WriteAllTextAsync("file.txt", text);
    Console.WriteLine("Dati scritti su file con successo");
}

static async Task ReadFromFile()
{
    try
    {
        string content = await File.ReadAllTextAsync("file.txt");
        Console.WriteLine("Contenuto del file: " + content);
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("File non trovato");
    }

}