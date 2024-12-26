namespace Lesson9;

public class Teacher : Person
{
    public string TeacherID { get; set; }
    public List<string> TeachingCourses { get; set; } = new List<string>();

    public Teacher(string firstName, string lastName, int age, string teacherId) : base(firstName, lastName, age)
    {
        TeacherID = teacherId;
    }

    public void AddCourse(string course) => TeachingCourses.Add(course);

    public void DisplayTeacherInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Mã giáo viên: {TeacherID}");
        Console.WriteLine("Các khóa học đang dạy:");
        foreach (var course in TeachingCourses)
        {
            Console.WriteLine(course);
        }
    }
}
