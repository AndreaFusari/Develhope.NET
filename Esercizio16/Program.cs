/*Create a HashSet<string>. Explore what happens when you add unique values to it. 
 * Does a HashSet consider strings with different capitalisations unique?*/

HashSet<string> set = new HashSet<string> { "ciao", "Ciao", "Bob", "Bob","Pippo"};
foreach (string s in set)
{
    Console.WriteLine(s); // output ciao, Ciao , Bob , Pippo  Considera uniche la stringhe con le stesse lettere se hanno maiuscole o minuscole diverse
}

