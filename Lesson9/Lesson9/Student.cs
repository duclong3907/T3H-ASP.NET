namespace Lesson9;

public class Student : Person
{
    public string StudentID { get; set; }
    public List<string> Courses { get; set; } = new List<string>();

    public Student(string firstName, string lastName, int age, string studentId) : base(firstName, lastName, age)
    {
        StudentID = studentId;
    }

    public void EnrollCourse(string course) => Courses.Add(course);

    public void DisplayStudentInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Mã sinh viên: {StudentID}");
        Console.WriteLine("Các khóa học đã đăng ký:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course);
        }
    }
}

