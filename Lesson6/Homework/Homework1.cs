using Library;
/*
 Bài 1: Xây dựng một chương trình quản lý điểm của học sinh:
- Lưu thông tin (tên, điểm toán, điểm lý, điểm hóa) trong một List<Student>.
- Tính điểm trung bình của từng học sinh và sắp xếp danh sách theo thứ tự điểm trung bình giảm dần.
 */
namespace Homework;

class Homework1
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        int n;
        Console.WriteLine("Enter number students: ");
        Validator.InputInteger(Console.ReadLine(), out n);
        double mathScore, physicsScore, chemistryScore;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter student name {i+1}: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter math score: ");
            Validator.InputDouble(Console.ReadLine(), out mathScore);
            checkGrade(mathScore);

            Console.WriteLine("Enter physics score: ");
            Validator.InputDouble(Console.ReadLine(), out physicsScore);
            checkGrade(physicsScore);

            Console.WriteLine("Enter chemistry score: ");
            Validator.InputDouble(Console.ReadLine(), out chemistryScore);
            checkGrade(chemistryScore);

            students.Add(new Student(name, mathScore, physicsScore, chemistryScore));
            Console.WriteLine();
        }

        Console.WriteLine("Before sorting: ");
        ShowingList.DisplayList<Student>(students);
        Console.WriteLine();
        Console.WriteLine("After sorting: ");
        BubbleSort(students);
        ShowingList.DisplayList<Student>(students);
    }

    static void checkGrade(double n)
    {
        if (n < 0 || n > 10)
        {
            do
            {
                Console.WriteLine("Score ranges from 0-10.");
                Console.WriteLine("Enter again:");
                Validator.InputDouble(Console.ReadLine(), out n);
            } while (n < 0 || n > 10);
        }
    }

    static void BubbleSort(List<Student> students)
    {
        for (int i = 0; i < students.Count - 1; i++)
        {
            for (int j = students.Count - 1; j > i; j--)
            {
                if (students[j].GetAverageScore() > students[j - 1].GetAverageScore())
                {
                    Student temp = students[j];
                    students[j] = students[j - 1];
                    students[j - 1] = temp;
                }
            }
        }
    }

}