using System;

namespace _040422
{
    internal class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.WriteLine("===========MENU===========");
            Console.WriteLine("1-Set Meeting\n2-Find Meetings Count\n3-Is Exists Meeting By Name\n4-Get Exist Meetings\n5-Quit");
            Console.Write("\nYour choice: ");

            string choise = Console.ReadLine();
            bool quit = false;
            MeetingSchedule _meetings = new MeetingSchedule();
            do
            {
                switch (choise)
                {
                    case "1":
                        Console.Write("Meeting Name: ");
                        string meetingName = Console.ReadLine();
                        Console.Write("Meeting From Date: ");
                        DateTime _fromTime = DateTime.Parse(Console.ReadLine());
                        Console.Write("Meeting To Date: ");
                        DateTime _toTime = DateTime.Parse(Console.ReadLine());
                        goto menu;
                    case "2":
                        Console.WriteLine("Enter the time you want to search: ");
                        DateTime _searchDateTime = DateTime.Parse(Console.ReadLine());
                        foreach (var item in _meetings.FindMeetingsCount(_searchDateTime))
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        goto menu;
                    case "3":
                        Console.WriteLine("Enter Meet name: ");
                        string _searchName = Console.ReadLine();
                        Console.WriteLine(_meetings.IsExistsMeetingByName(_searchName));
                        goto menu;
                    case "4":
                        Console.WriteLine("Enter meetings name: ");
                        string _searchMeetName = Console.ReadLine();
                        foreach (var item in _meetings.GetExistMeetings(_searchMeetName))
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        goto menu;
                    case "5":
                        Console.WriteLine("Prosses ended...");
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Choose between 1 and 3");
                        goto menu;
                }
            } while (!quit);

        }
    }
}
