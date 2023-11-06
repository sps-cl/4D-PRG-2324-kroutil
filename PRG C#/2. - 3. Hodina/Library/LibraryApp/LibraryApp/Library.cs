using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.models;
using LibraryApp.exceptions;

namespace LibraryApp
{
    internal class Library<T> where T : LibraryItem<T>
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void ListItems()
        {
            Console.WriteLine("Knihovní pčedměty:");
            foreach (T Item in items)
            {
                Item.DisplayInfo();
            }
        }

        public void CheckoutItem(int id)
        {
            T itemToCheckout = items.Find(i => i.Id == id);
            if (itemToCheckout != null)
            {

                if (itemToCheckout.IsAvaiable)
                {
                    itemToCheckout.IsAvaiable = false;
                    Console.WriteLine($"Vypujčil jsem si knížku: {itemToCheckout.Title}");
                }
                else
                {
                    throw new NotAvailableException($"Položka s ID ${itemToCheckout.Id} nebyla nalezena");
                }
            }
            else
            {
                throw new NotFoundException();
            }
        }

        public void ReturnItem(int id);
        {
         T itemToCheckout = items.Find(i => i.Id == id);
            if (itemToCheckout != null)
            {

                if (itemToCheckout.IsAvaiable)
                {
                    itemToCheckout.IsAvaiable = false;
                    Console.WriteLine($"Vypujčil jsem si knížku: {itemToCheckout.Title}");
                }
                else
                {
                    throw new NotAvailableException($"Položka s ID ${itemToCheckout.Id} nebyla nalezena");
}
            }
            else
            {
                throw new NotFoundException();
            }
        }

    }
}
