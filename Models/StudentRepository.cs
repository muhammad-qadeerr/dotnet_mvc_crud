namespace MVC_in_Dotnet.Models
{
    public static class StudentRepository
    {
        public static List<Student> students = new List<Student>();

        static StudentRepository()
        {
            students.Add(new Student { Id=1, Name="Qadeer", RollNo=37, CGPA=3.14f, Semester="8th"});
            students.Add(new Student { Id = 2, Name = "Abdullah", RollNo = 52, CGPA = 3.3f, Semester = "8th" });
            students.Add(new Student { Id = 3, Name = "Hanzla", RollNo = 53, CGPA = 3.7f, Semester = "8th" });
            students.Add(new Student { Id = 4, Name = "Uzair", RollNo = 52, CGPA = 4f, Semester = "8th" });

        }
        public static void AddStudent(Student s)
        {
            students.Add(s);    
        }
    }
}
