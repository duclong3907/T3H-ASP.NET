namespace Lesson9;

public class Course
{
    public string CourseName { get; set; }
    public Teacher CourseTeacher { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();

    public Course(string courseName, Teacher courseTeacher)
    {
        CourseName = courseName;
        CourseTeacher = courseTeacher;
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
        student.EnrollCourse(CourseName);
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Khóa học: {CourseName}");
        Console.WriteLine("Giáo viên phụ trách:");
        CourseTeacher.DisplayInfo();
        Console.WriteLine("Danh sách sinh viên đã đăng ký:");
        foreach (var student in EnrolledStudents)
        {
            student.DisplayInfo();
        }
    }
}
