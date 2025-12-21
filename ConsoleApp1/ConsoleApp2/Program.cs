namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ali Rezaei", 20, "01", "Computer Science");
            Student student2 = new Student("Sara Ahmadi", 22, "02", "Electrical Engineering");

            Professor professor1 = new Professor("Dr. Mohammadi", 45, "03", "Data Structures");
            Professor professor2 = new Professor("Dr. Alavi", 50, "04", "Algorithms");

            Console.WriteLine("=== Individual Information ===");
            student1.DisplayInfo();
            Console.WriteLine();
            professor1.DisplayInfo();
            Console.WriteLine();

            Person[] universityPeople = new Person[]
            {
            student1,
            student2,
            professor1,
            professor2
            };

            University university = new University();
            university.DisplayAllPeople(universityPeople);

            university.ShowAllDetails(universityPeople);

            Console.WriteLine("\n=== Method Overloading Example ===");
            DisplayPersonInfo(student1); 
            DisplayPersonInfo(professor1);

            Console.WriteLine("\n=== Using Base Class Reference ===");
            Person personAsStudent = new Student("Reza Karimi", 21, "05", "Mathematics");
            Person personAsProfessor = new Professor("Dr. Hashemi", 55, "06", "Physics");

            personAsStudent.DisplayInfo(); 
            Console.WriteLine();
            personAsProfessor.DisplayInfo(); 
        }

        static void DisplayPersonInfo(Student student)
        {
            Console.WriteLine($"Student: {student.Name}, Major: {student.Major}");
        }

        static void DisplayPersonInfo(Professor professor)
        {
            Console.WriteLine($"Professor: {professor.Name}, Subject: {professor.Subject}");
        }
    
    }
}
