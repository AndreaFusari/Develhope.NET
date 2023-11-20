/*Let's do the same for a Stack. The options are:
 * Push
 * Pop
 * Peek
 */

using System.ComponentModel.Design;

Stack<string> stack = new Stack<string>();

while (true)
{
    Console.WriteLine("\nDigita il numero dell'operazione da effettuare :\n");
    Console.WriteLine(" [1] Aggiungi un elemento");
    Console.WriteLine(" [2] Elimina un elemento");
    Console.WriteLine(" [3] Visualizza il primo elemento\n");

    string scelta = Console.ReadLine();
    int number = int.Parse(scelta);

    if (number == 1)
    {
        Console.WriteLine("\nDigita del testo\n");
        string text = Console.ReadLine();
        stack.Push(text);
        Console.WriteLine("\nRaccolta aggiornata :");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
    else if (number == 2)
    {
        Console.WriteLine("\nEliminazione in corso ...\n");
        stack.Pop();
        Console.WriteLine("Raccolta aggionrnata :");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
    else if (number == 3)
        {
        Console.WriteLine("\nIl primo elemento della raccolta è :");
        Console.WriteLine(stack.Peek());
        }
    else
        {
        Console.WriteLine("Selezione non disponibile");
        }
        }
    



