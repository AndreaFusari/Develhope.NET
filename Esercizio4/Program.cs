// Allow a user to input some text. Display the text back to them, but in reverse!
using System.Linq;

Console.WriteLine("Scrivi del testo");
string testo = Console.ReadLine();

string reverse = new string(testo.Reverse().ToArray());
Console.WriteLine(reverse);