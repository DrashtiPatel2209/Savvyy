using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SavvyyAssignment.Models;

namespace SavvyyAssignment.Data
{
    public class SqlBookRepository : IBookRepo
    {
        private readonly BookContext _context;

        public SqlBookRepository(BookContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Books.Where(n => n.id == id).FirstOrDefault();
        }

       
        public void CreateBook(Book bookToInsert)
        {
            if(bookToInsert == null) { 
                throw new ArgumentNullException();
            } 
            _context.Books.Add(bookToInsert);

        }

        public void SaveChanges()
        {
             _context.SaveChanges();
        }
    }
}
