namespace Lesson5
{
    struct Student
    {
        // Các trường dữ liệu (thuộc tính)  lưu trữ thông tin của sinh viên
        public int Id;
        public Guid MeetingId;
        public string Name;
        public int Age;
        public Student(int id, string name, int age, Guid meetingId)
        {
            Id = id;
            Name = name;
            Age = age;
            MeetingId = meetingId;
        }


        // Phương thức (method) -- giải quyết các nghiệp vụ của phần (thuộc tính)  -behaviour
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
        public void DisplayInfo111(string a, int ad)
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
        public Student SearchStudentById(int id)
        {
            return new Student { Id = id };
        }
    }
}
