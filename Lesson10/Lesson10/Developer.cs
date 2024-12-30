namespace Lesson10;

class Developer : Employee
{
    private int OvertimeHours { get; set; }
    private decimal OvertimeRate { get; set; }

    public Developer(int overtimeHours, decimal overtimeRate, string name)
    {
        OvertimeHours = overtimeHours;
        OvertimeRate = overtimeRate;
        this.Name = name;
    }
    public override decimal CalculateSalary()
    {
        return base.CalculateSalary() + (OvertimeHours * OvertimeRate);
    }
}
