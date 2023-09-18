using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.models
{
    internal class DVD : LibraryItem<DVD>
    {
        public int LenghtOfTrack { get; }
        public string Author { get; }

        public DVD(int LenghtOfTrack, string Author, int id, string Title) : base(id, Title)
        {
            this.LenghtOfTrack = LenghtOfTrack;
            this.Author = Author;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Author} a délka skladby: {LenghtOfTrack}");
        }
    }
}
