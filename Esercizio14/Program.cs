/*Create a console application that uses a LinkedList to represent a train route with various stations. 
 * Add and remove stations, and display the route. Can you make the train station into a class?*/
using Esercizio14;


LinkedList<TrainStation> list = new LinkedList<TrainStation>();
void Start()
{
    TrainStation Milano = new TrainStation("Milano", "Piazza IV Novembre");
    TrainStation Firenze = new TrainStation("Firenze", "Via Firenze 9");
    TrainStation Roma = new TrainStation("Roma", "Corso Cavour 15");
    TrainStation Napoli = new TrainStation("Napoli", "Via Pordenone 2");

    list.AddFirst(Milano);
    list.AddLast(Firenze);
    list.AddLast(Roma);
    list.AddLast(Napoli);
}
void PrintTrainRoute()
{
    for (int i = 0; i < list.Count; i++)
    {

        if (i == 0)
        {
            Console.WriteLine($"Stazione di partenza -> {list.ElementAt(i)}");

        }
        else if (i == list.Count - 1)
        {
            Console.WriteLine($"Stazione di arrivo -> {list.ElementAt(i)}");

        }
        else
        {
            Console.WriteLine($"Stazione successiva -> {list.ElementAt(i)}");

        }
    }
}

Start();
PrintTrainRoute();
Console.WriteLine("\nLa stazione di Milano è chiusa questa è la nuova tratta:");
list.RemoveFirst();
list.AddFirst(new TrainStation("Lodi","Piazza Ovidio 25"));
PrintTrainRoute();
Console.WriteLine();
   
    


