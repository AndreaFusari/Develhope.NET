/*Create an application that allows a user to give a path to a .txt file. 
 * That file should contain a lot of words, with some duplicates. 
 * The application should create a Dictionary<string, int> to store every unique word, and how often they appear in the file.
 * For this purpose, words are not case-sensitive.*/

using System.Diagnostics.Tracing;
using System.Threading.Channels;
Console.WriteLine("Scrivi delle parole e alcune di queste ripetile più volte");
File.WriteAllText("file.txt", Console.ReadLine());

string[] lines = File.ReadAllLines("file.txt");
// inizializzo un dictionary specificando di ignorare la distinzione tra maiuscole e minuscole
Dictionary<string,int> map = new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);

Console.WriteLine("\nEcco il contatore delle parole:");

foreach (string line in lines)
{   
    // con il metodo .Split creo un nuovo array di stringhe che contiene le singole parole

    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    // per ogni parola trovata effettuo un controllo : se è presente nel Dictionary aumento il 'value' di 1
    // se no l'aggiungo al Dictionary assegnando al 'value' il valore di 1 e alla 'key' la 'word' corrente del ciclo

   foreach (var word in words)
   {
       if (map.ContainsKey(word))
        {
            map[word] = map[word] + 1;
        } 
       else
        {
            map.Add(word, 1 );
        }
   }
   // infine stampo le coppie key/value
    foreach (var pair in map)
    {
        Console.WriteLine($"_ Hai scritto '{pair.Key}' {pair.Value} volte");
    }

}

