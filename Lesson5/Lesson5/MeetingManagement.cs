using Library;
namespace Lesson5;
/*
 Quản lý lịch họp (Meeting Management)
Tạo struct Meeting với các thuộc tính:
    MeetingId (kiểu Guid),
    Title (tên buổi họp),
    StartTime (kiểu DateTime),
    EndTime (kiểu DateTime),
    Participants (danh sách các email tham gia).
Viết chương trình:
Nhập thông tin cho 5 buổi họp.
Hiển thị danh sách các buổi họp, sắp xếp theo thời gian bắt đầu.
Kiểm tra xem một thời gian nhất định có bị trùng với bất kỳ buổi họp nào không. nếu trùng 
thì hiển thị thông tin ra màn hình
 */
class MeetingManagement
{
    static void Main()
    {
        int n = 5;
        List<Meeting> meetings = new List<Meeting>();
        string tilte = string.Empty;
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now;
        List<string> participants = new List<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enter meeting {i}");
            Console.Write("Title: ");
            tilte = Console.ReadLine();

            startTime = Validator.GetValidDateTimeInput("Start time (yyyy-MM-dd HH:mm): ");
            endTime = Validator.GetValidDateTimeInput("End time (yyyy-MM-dd HH:mm): ");

            Console.Write("Participants: ");
            participants = Validator.GetValidParticipants();

            meetings.Add(new Meeting(Guid.NewGuid(), tilte, startTime, endTime, participants));
        }

        meetings.Sort((m1, m2) => m1.StartTime.CompareTo(m2.StartTime));

        foreach (var meeting in meetings)
        {
            Console.WriteLine(meeting);
        }

        //check time trùng
        DateTime checkTime = DateTime.Parse(Console.ReadLine());

        bool isOverlapping = false;
        foreach (var meeting in meetings)
        {
            if (checkTime >= meeting.StartTime && checkTime <= meeting.EndTime)
            {
                Console.WriteLine($"Meeting {meeting.Title} is overlapping");
                isOverlapping = true;
            }
        }

        if (!isOverlapping)
        {
            Console.WriteLine("No meeting is overlapping");
        }
    }
}