/*There is a crucial difference between FirstOrDefault and SingleOrDefault. 
 * If I only want 1 item, and want to make sure that is the only item with that value, 
 * which do I use? Play around with both methods to see the differences. 
 * Which one should you use, and why?*/ 
Random random = new Random();
var numbers  = Enumerable.Range(0,10).Select(i => random.Next(0,101)).ToList();
numbers.ForEach(Console.WriteLine);

var result1 = numbers.FirstOrDefault(); 
//questo metodo ritorna il primo elemento della lista o default se la lista è vuota

var result2 = numbers.Skip(9).SingleOrDefault(); 
//questo metodo ritorna un singolo elemento o default se la lista è vuota e lancia un'eccezione se sono presenti altri elementi
//non userei nessuno di questi due metodi per ottenere un elemento univoco da una lista
Console.WriteLine($"FirstOrDefault : {result1}");
Console.WriteLine($"SingleOrDefault : {result2}");