using System;
using EventApp;
using EventApp.Models;

public class Program
{

    public static void Main(string[] args)
    {

        Guest guest1 = new Guest("Ethan", "Winters", 30);
        Guest guest2 = new Guest("Mia", "Winters", 29);
        Guest guest3 = new Guest("Chris", "Redfield", 48);
        Guest guest4 = new Guest("Karl", "Heisenberg", 52);

        Performer performer1 = new Performer("Salvatore", "Moreau", 80, "guitarist");
        Performer performer2 = new Performer("Donna", "Beneviento", 43, "drummer");
        Performer performer3 = new Performer("Alcina", "Dimitrescu", 129, "singer");

        Event event1 = new Event("SVATBA", "Wintersss");

        event1.AddAtendee(guest1);
        event1.AddAtendee(guest2);
        event1.AddAtendee(guest3);

        event1.AddAtendee(performer1);
        event1.AddAtendee(performer2);
        event1.AddAtendee(performer3);

        guest1.processInvitation(true);
        guest2.processInvitation(false);

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
        Console.WriteLine("");

        event1.RemoveAtendee("Karl", "Heisenberg");

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
    }

}