using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.model
{
    public class Event
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public List<Person> Attendees { get; set; }

        public Event(string eventName, DateTime eventDate)
        {
            EventName = eventName;
            EventDate = eventDate;
            Attendees = new List<Person>();
        }
    }
}
