/*Other than being hard to spell, a queue is very useful for keeping things in the right order. 
 * Create an application that allows 3 options: Queue, Dequeue,  Peek 
 * When the user selects 1, allow them to add a string to the queue. 
 * Option 2 should dequeue an item and print it to the console. 
 * Option 3 should print the result of the Peek() method.*/

using System.Threading.Channels;

Queue<string> queue = new Queue<string>();

while (true)
{
    Console.WriteLine("\nDigita il numero dell'operazione da effettuare :\n");
    Console.WriteLine(" [1] Aggiungi un elemento");
    Console.WriteLine(" [2] Elimina un elemento");
    Console.WriteLine(" [3] Visualizza il primo elemento\n");

    string scelta = Console.ReadLine();
    int number = int.Parse(scelta);

    switch (number)
    {
        case 1:
            {
                Console.WriteLine("\nDigita del testo\n");
                string text = Console.ReadLine();
                queue.Enqueue(text);
                Console.WriteLine("\nRaccolta aggiornata :");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            break;

        case 2:
            {
                Console.WriteLine("\nEliminazione in corso ...\n");
                queue.Dequeue();
                Console.WriteLine("Raccolta aggionrnata :");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            break;

        case 3:
            {
                Console.WriteLine("\nIl primo elemento della raccolta è :");
                Console.WriteLine(queue.Peek());
                break;
            }

        default:
            {
                Console.WriteLine("Selezione non disponibile");
            }
            return;
    }
}





