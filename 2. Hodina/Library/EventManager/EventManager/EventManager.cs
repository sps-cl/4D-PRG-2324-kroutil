using EventManager.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class EventManager
    {
        public List<Event> Events { get; set; }

        public EventManager()
        {
            Events = new List<Event>();
        }

        public void CreateEvent(string eventName, DateTime eventDate)
        {
            Event newEvent = new Event(eventName, eventDate);
            Events.Add(newEvent);
        }

        public void AddPersonToEvent(string eventName, Person person)
        {
            Event targetEvent = Events.Find(e => e.EventName == eventName);
            if (targetEvent != null)
            {
                targetEvent.Attendees.Add(person);
            }
            else
            {
                Console.WriteLine($"No event found with the name {eventName}");
            }
        }

        public void ListEvents()
        {
            foreach (Event e in Events)
            {
                Console.WriteLine($"Event: {e.EventName}, Date: {e.EventDate}");
                Console.WriteLine("Attendees:");
                foreach (Person p in e.Attendees)
                {
                    Console.WriteLine($"{p.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
