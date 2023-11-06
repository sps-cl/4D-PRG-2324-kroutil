using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.models
{
    internal abstract class LibraryItem<T>
    {
        public int ID { get; }
        public string Title { get; }
        public bool IsAvaiable { get; set; }

        public LibraryItem(int id, string Title) 
        {
            this.ID = id;
            this.Title = Title;
            this.IsAvaiable = true;
        }
        public abstract void DisplayInfo();
    }
}
