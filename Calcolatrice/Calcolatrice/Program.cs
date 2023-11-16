using Calcolatrice;

Calculator c; // dichiaro la classe astratta
Console.WriteLine("Digita il primo numero");
string a = Console.ReadLine();

if (string.IsNullOrEmpty(a))
{
    Console.WriteLine("input invalido");
    Environment.Exit(1);
    return;
}
Console.WriteLine("Digita l'operatore");
var op = Console.ReadLine();
if (string.IsNullOrEmpty(op)||op.Length!=1)
{
    Console.WriteLine("input invalido");
    Environment.Exit(1);
    return;
}

Console.WriteLine("Digita il secondo numero");
string b = Console.ReadLine();

if (string.IsNullOrEmpty(b))
{
    Console.WriteLine("input invalido");
    Environment.Exit(1);
    return;
}
switch (op)
{
    case "+": c = new Addizione(); // creo un'istanza della superclasse di tipo "addizione"
        c.Calculate(a, b);

             Console.WriteLine(c.expression);
        break;

    case "-": c = new Sottrazione ();
        c.Calculate(a, b);
             Console.WriteLine(c.expression);
        break;

    case "*":
            c = new Moltiplicazione ();
        c.Calculate(a, b);
        Console.WriteLine(c.expression);
        break;

    case "/":
            c = new Divisione ();
        c.Calculate(a, b);
        Console.WriteLine(c.expression);    
        break;

    default: Console.WriteLine("Errore, riprova!");
        break;
}

