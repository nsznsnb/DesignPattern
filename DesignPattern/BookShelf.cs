using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BookShelf : Iterable<Book>
    {
        private List<Book> _books;

        public int Length { get { return _books.Count(); } }   

        public BookShelf()
        {
            this._books = new List<Book>();
        }

        public Book GetbookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book) {
            this._books.Add(book);
        }

        public Iterator<Book> Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
