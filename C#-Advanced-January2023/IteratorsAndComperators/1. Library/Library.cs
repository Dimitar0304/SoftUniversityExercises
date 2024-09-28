using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    class Library:IEnumerable<Book>
    {
        private List<Book> _books;
        public Library(params Book[] books)
        {
            _books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in _books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
