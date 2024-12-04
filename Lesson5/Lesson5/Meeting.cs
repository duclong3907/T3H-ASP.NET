namespace Lesson5
{
    struct Meeting
    {
        public Guid MeetingId;
        public string Title;
        public DateTime StartTime;
        public DateTime EndTime;
        public List<string> Participants;

        public Meeting() { }

        public Meeting(Guid meetingId, string title, DateTime startTime, DateTime endTime, List<string> participants)
        {
            MeetingId = meetingId;
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            Participants = participants;
        }

        public override string ToString()
            => $"ID: {MeetingId}, Title: {Title}, Start: {StartTime}, End: {EndTime}, Participants: {string.Join(", ", Participants)}";
    }
}
