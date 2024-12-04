namespace Library
{
    public class Validator
    {
        public static DateTime GetValidDateTimeInput(string prompt)
        {
            DateTime dateTime;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out dateTime))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date/time format. Please enter again.");
                }
            }
            return dateTime;
        }

        public static List<string> GetValidParticipants()
        {
            List<string> participants;
            while (true)
            {
                Console.Write("Participants (comma separated): ");
                string input = Console.ReadLine();
                if (ValidateParticipants(input, out participants))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid participants format. Please enter again.");
                }
            }
            return participants;
        }

        private static bool ValidateParticipants(string input, out List<string> participants)
        {
            participants = new List<string>();
            var participantArray = input.Split(',');

            foreach (var email in participantArray)
            {
                var trimmedEmail = email.Trim();
                if (!string.IsNullOrEmpty(trimmedEmail))
                {
                    participants.Add(trimmedEmail);
                }
                else
                {
                    return false;
                }
            }

            return participants.Count > 0;
        }
    }
}
