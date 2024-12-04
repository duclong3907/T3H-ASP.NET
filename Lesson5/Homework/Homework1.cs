namespace Homework;
/*
 Bài 1: Tạo một struct tên là Student với các thuộc tính:
	Name (tên sinh viên, kiểu string)
	Age (tuổi, kiểu int)
	GPA (điểm trung bình, kiểu double)
    Viết chương trình:
	- Nhập thông tin cho n sinh viên (n được nhập từ bàn phím).
	- Hiển thị danh sách sinh viên với định dạng: "Name - Age - GPA".
	- Tìm và hiển thị sinh viên có điểm GPA cao nhất.
*/
public class Homework1
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            students[i].Name = name;

            Console.Write("Age: ");
            string ageInput = Console.ReadLine();
            if (string.IsNullOrEmpty(ageInput) || !int.TryParse(ageInput, out int age) || age <= 0 || age >= 100)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            students[i].Age = age;

            Console.Write("GPA: ");
            string gpaInput = Console.ReadLine();
            if (string.IsNullOrEmpty(gpaInput) || !double.TryParse(gpaInput, out double gpa) || gpa <= 0 || gpa >= 10)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            students[i].GPA = gpa;
        }
        Console.WriteLine("List student:");
        DisplayStudents(students);
        Console.WriteLine();
        Console.WriteLine($"Student have max gpa is: ");
        FindMaxGPAStudent(students).DisplayInfo();
    }

    static void DisplayStudents(Student[] students)
    {
        foreach (var student in students)
        {
            student.DisplayInfo();
        }
    }

    static Student FindMaxGPAStudent(Student[] students)
    {
        Student maxGPAStudent = students[0];
        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].GPA > maxGPAStudent.GPA)
            {
                maxGPAStudent = students[i];
            }
        }
        return maxGPAStudent;
    }
}