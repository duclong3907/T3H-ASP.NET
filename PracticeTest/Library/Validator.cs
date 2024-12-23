namespace Library;

public static class Validator
{
    public static void InputInteger(string input, out int n)
    {
        if (!int.TryParse(input, out n) || n < 0)
        {
            Console.WriteLine("Invalid! Input must be an integer >= 0.");
            return;
        }
    }

    public static void InputDouble(string input, out double n)
    {
        if (!double.TryParse(input, out n) || n < 0)
        {
            Console.WriteLine("Invalid! Input must be a double >= 0.");
            return;
        }
    }
}
