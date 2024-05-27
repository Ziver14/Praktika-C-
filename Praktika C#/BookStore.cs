using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_
{
    public class BookStore<T> where T : IBook
    {
        private List<T> books = new List<T> ();

        public void AddBook(T book) 
        {
           books.Add(book);
        }
        public void RemoveBook(T book) 
        {
            books.Remove(book);
        }

        public IEnumerable<T> FindBookByAutor(string autor)
        {
            return books.Where(b=>b.Autor ==  autor);
        }
        public IEnumerable<T> FindBookByGenre(string genre)
        {
            return books.Where(b => b.Genre == genre);
        }

        public IEnumerable<T> GetBooksSortedBy(Func<T,object>keySelector)
        {
            return books.OrderBy(keySelector);
        }

        public double CalculateOfPrice()
        {
            return books.Sum(b => b.Price);
        }

        public T GetMostExpensiveBook()
        {
            return books.OrderByDescending(b=> b.Price).FirstOrDefault();
        }
    }
}
