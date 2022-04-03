using System;
using System.Collections.Generic;
using System.Text;

namespace _040422
{
    internal class MeetingSchedule
    {
        List<Meeting> meetingList;

        public MeetingSchedule()
        {
            meetingList = new List<Meeting>();
        }

        public void SetMeetings(string _name, DateTime _from, DateTime _to)
        {
            if (meetingList.Count == 0)
            {
                meetingList.Add(new Meeting() { Name = _name, FromDate = _from, ToDate = _to });
            }
            else if (meetingList.Count != 0)
            {

                foreach (var item in meetingList)
                {
                    if (item.Name == _name || item.FromDate == _from || item.ToDate == _to)
                        throw new MeetingeException("Bele bir meeting movcuddur.");
                }
                meetingList.Add(new Meeting() { Name = _name, FromDate = _from, ToDate = _to });
            }
        }

        public List<Meeting> FindMeetingsCount(DateTime dateTime)
        {
            int meetingCount = 0; //say deyilib deye bunu yazdim artir amma
                                  //ekranda gosterilimir geriye list qaytaram deye
            List<Meeting> newList = new List<Meeting>();
            foreach (var item in meetingList)
            {
                if (dateTime < item.FromDate)
                {
                    newList.Add(item);
                    meetingCount++;
                }
            }
            return newList;
        }

        public bool IsExistsMeetingByName(string _name)
        {
            foreach (var meeting in meetingList)
            {
                if (meeting.Name.Contains(_name))
                    return true;
            }
            return false;
        }

        public List<Meeting> GetExistMeetings(string _name)
        {
            List<Meeting> newList = new List<Meeting>();
            foreach (var item in meetingList)
            {
                if (item.Name.Contains(_name))
                    newList.Add(item);
            }
            return newList;
        }


    }
}