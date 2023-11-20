/*An ArrayList is an interesting data collection. It allows any object to be added. 
 * Create a console app where you make an ArrayList. Try adding numbers and text, 
 * then add anything you want. Try printing the contents out to the console. 
 * Do you notice anything about how items are printed. */

using Esercizio11;
using System.Collections;

ArrayList list = new ArrayList { 1, "ciao", new Person ( 45 , "Bob") };

foreach (var value in list)
{
    Console.WriteLine(value);
}
