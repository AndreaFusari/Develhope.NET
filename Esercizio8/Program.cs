// A palindrome is a word or sentence that is the same spelled backwards.
// Can you write a program that checks if the user input is a palindrome?
// Palindromes are not case sensitive.

Console.WriteLine("Inserisci una parola");
string? parola = Console.ReadLine();
string reversedString = "";

for (int i = parola.Length - 1; i >= 0; i--){
    reversedString += parola[i];
}
if ( reversedString.Equals(parola))
{
    Console.WriteLine($"La parola inserita '{parola}' è palindroma");
}
else
{
    Console.WriteLine($"La parola inserita '{parola}' non è palindroma");


}
