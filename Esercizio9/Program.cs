// We want a calculator that can convert from Celcius to Fahrenheit.
// To convert from Celsius to Fahrenheit, multiply by 1.8 and add 32.
// But what if we want to convert Fahrenheit to Celsius as well?
// Extend the program so that the user can first choose if they want to convert °C
// to °F or the other way around. Oh btw, you can convert Fahrenheit to Celsius by subtracting 32 and multiplying by .5556.
Console.WriteLine("Digitare 'a' per convertire °C in °F o 'b' per °F in °C ");
string scelta = Console.ReadLine();
Console.WriteLine("Inserisci la temperatura");
string temp= Console.ReadLine();
double tempNum = double.Parse(temp);
if (scelta.Equals("a"))
{
    double tempFahrenheit = (tempNum * 1.8) + 32;

    Console.WriteLine($"{temp} gradi Celsius corrispondono a {tempFahrenheit} gradi Fahrenheit");
}
else if (scelta.Equals("b"))
{
    double tempCelsius = (tempNum - 32) * 1.8;
    Console.WriteLine($"{temp} gradi Fahrenheit corrispondono a {tempCelsius} gradi Celsius");
}