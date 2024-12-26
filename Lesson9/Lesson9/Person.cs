namespace Lesson9;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public void DisplayInfo() => Console.WriteLine($"Họ tên: {FirstName} {LastName}, Tuổi: {Age}");
  
}