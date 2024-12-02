using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Library : IEnumerable<Book>
    {
        private Book[] books = new Book[0];
        private int count;
        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        
        public int Count
        {
            get { return count; }
        }
        public void Add(Book book)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, books.Length + 1);
            }
            books[count] = book;
            count++;
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new Librarian(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
