namespace Homework;

class Student
{
    public string Name { get; set; }
    public double MathScore { get; set; }
    public double PhysicsScore { get; set; }
    public double ChemistryScore { get; set; }

    public Student(string name, double mathScore, double physicsScore, double chemistryScore)
    {
        Name = name;
        MathScore = mathScore;
        PhysicsScore = physicsScore;
        ChemistryScore = chemistryScore;
    }

    public double GetAverageScore() => (MathScore + PhysicsScore + ChemistryScore) / 3;

    public override string ToString() => $"Name: {Name}, Average Score: {GetAverageScore()}";

}
