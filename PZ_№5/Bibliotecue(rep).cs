using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ__5
{
    class Bibliotecue_rep
    {
        private Book book;
        private bool isAvailable;

        public Bibliotecue_rep(Book book)
        {
            this.book = book;
            isAvailable = true;
        }

        public void PutOnAccount()
        {
            isAvailable = true;
            Console.WriteLine($"Книга {book.Name} поставлена на учет ");
        }
        




    }
}
