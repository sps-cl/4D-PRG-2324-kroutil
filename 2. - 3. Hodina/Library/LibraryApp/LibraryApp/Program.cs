using LibraryApp.exceptions;
using LibraryApp.models;

namespace LibraryApp
{

    public enum LibraryItemType
    internal class Program
    {
        var library = new Library<LibraryItem<LibraryItemType>>();
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        try 
        {
            library.ReturnItem(12235465423125);
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine
        }
    }
}