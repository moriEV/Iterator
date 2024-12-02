using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Librarian:IEnumerator<Book>
    {
        private Library library;
        private int current = -1;
        public Librarian(Library enumerable)
        {
            this.library = enumerable;
        }
        public bool MoveNext()
        {
            if (current < library.Count - 1) 
            {
                current++;
                return true;
            }
            return false;
        }
        public void Reset() 
        {
            current = -1;
        }
        public Book Current
        {
            get { return library[current]; }
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            // Здесь можно освободить ресурсы, если они есть
        }
    }
}
