using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BookShelfIterator : Iterator<Book>
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this._bookShelf = bookShelf;
            this._index = 0;
        }
        public bool HasNext()
        {
            if (_index < _bookShelf.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Book Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException();
            }

            var book = _bookShelf.GetbookAt(_index);
            _index++;
            return book;

        }
    }
}
