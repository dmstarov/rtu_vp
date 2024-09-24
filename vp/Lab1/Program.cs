using ClassLibraryLab1;

class Program
{
    static void Main(string[] args)
    {
        StudentsData studentsData = new StudentsData();
        studentsData.Add(new Student("Dmitrijs", "Starov", "1", "DDBD", "starov2@gmail.com"));
        studentsData.Add(new Student("Ivans", "Starovs", "2", "DDBI2", "starov22@gmail.com"));

        studentsData.Save();
        studentsData.Load();

        foreach (var student in studentsData.Students)
        {
            Console.WriteLine(student);
        }
    }
}