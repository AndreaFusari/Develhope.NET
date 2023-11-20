/*Edit the collection of students from exercise 9, Grading the students. 
 * Create two students with the same grade, that grade should be the highest. 
 * How does your application deal with that? If needed, change the application to allow multiple students to have the highest grade. 
 * Extra points if you can print out their names in alphabetical order.*/

using Esercizio18;

// creo e riempio una lista con 10 studenti studenti

var random = new Random();
List<Student> students = new List<Student>();
string[] names = new string[] { "Bob", "Alice", "Piero", "Pippo", "Aldo", "Stan", "Pluto", "Carlo" };

for (int i = 0; i < 10; i++)
{
    string Name = names[random.Next(0, names.Length)];
    int Grade = random.Next(0, 11);
    Student student = new Student(Name, Grade);
    students.Add(student);
}

//stampo la lista di studenti ordinata in base ai voti e in base ai nomi

students.Sort((student1,student2)=>student1.Grade.CompareTo(student2.Grade));
Console.WriteLine("Studenti in ordine di voto :");
students.ForEach(Console.WriteLine);
students.Sort((student1,student2)=>student1.Name.CompareTo(student2.Name));
Console.WriteLine();
Console.WriteLine("Studenti in ordine di nome :");
students.ForEach(Console.WriteLine);

// calcolo la media dei voti degli studenti

int sum = 0;
foreach (Student student in students)
{
    sum += student.Grade;
}
double avarageGrade = (double)sum / students.Count;
Console.WriteLine("\nLa media voti degli studenti è " + avarageGrade + "\n");
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




