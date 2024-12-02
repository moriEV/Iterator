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
        List<Book> books = new List<Book>();
        public Book this[int index]
        {
            get { return books[index]; }
            set { books.Insert(index, value); }
        }
        
        public int Count
        {
            get { return books.Count; }
        }
        public void Add(Book book)
        {
            books.Add(book);
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
