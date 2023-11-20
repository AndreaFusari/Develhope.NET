/*Create a data collection that holds 10 students. The Student class should contain a Name and Grade.
 * Write a program that calculates the average grade, as well as print out the student with the highest grade.*/

using Esercizio18;

// creo e riempio una lista con 10 studenti studenti

var random = new Random();
List<Student> students = new List<Student>();
string[] names = new string[] { "Bob", "Alice", "Piero", "Pippo", "Aldo", "Stan", "Pluto", "Carlo" };
Console.WriteLine("Studenti della classe :");

for (int i = 0; i < 10; i++)
{
    string Name = names[random.Next(0, names.Length)];
    int Grade = random.Next(0, 11);
    Student student = new Student(Name, Grade);
    students.Add(student);
    Console.WriteLine(student);


}

// calcolo la media dei voti degli studenti

int sum = 0;
foreach (Student student in students)
{
    sum += student.Grade;
}
double avarageGrade = (double) sum / students.Count;
Console.WriteLine("La media voti degli studenti è " + avarageGrade + "\n");
Console.WriteLine("I migliori studenti sono :");

// calcolo il voto massimo tra gli studenti

int maxGrade = 0;
foreach (Student student in students)
{
    if (student.Grade > maxGrade)
    {
        maxGrade = student.Grade;
    
    }
}
// uso il voto massimo come condizione per trovare i migliori studenti

foreach (Student student in students)
{
    if ((student.Grade == maxGrade))
    {
        Console.WriteLine(student);
    }
}



