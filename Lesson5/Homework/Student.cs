namespace Homework
{
    struct Student
    {
        public string Name;
        public int Age;
        public double GPA;
        public void DisplayInfo() => Console.WriteLine($"{Name} - {Age} - {GPA}");
    }
}
