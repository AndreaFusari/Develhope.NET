/*Create a List<int>. The list should have 1000 random numbers. 
 * Write a program that finds the minimum and maximum numbers in that list.*/

var random = new Random();
int max = 0;
int min = int.MaxValue;

List<int> list = new List<int>();

for (int i = 0; i < 1000; i++)
{
    list.Add(random.Next(0,1001));
}
foreach (var item in list)
{
    if (item < min) {  min = item; }
    if (item > max) {  max = item; }
}

Console.WriteLine($"Il numero massimo è {max}\nIl numero minimo è {min}");