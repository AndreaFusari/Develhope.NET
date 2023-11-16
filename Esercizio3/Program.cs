// Create a simple calculator that allows the user to input two numbers.
// Then add the two numbers together and display the sum to the user.
Console.WriteLine("Digita il primo numero");

string primoNumero = Console.ReadLine();
int a = int.Parse(primoNumero);

Console.WriteLine("Digita il secondo numero");

string secondoNumero = Console.ReadLine();
int b = int.Parse(secondoNumero);

Console.WriteLine($"La somma {a} + {b} = {a + b}");

