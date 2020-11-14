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

        public void UpdateBook(Book bookToUpdate)
        {
            if (bookToUpdate == null)
            {
                throw new ArgumentNullException();
            }
            _context.Books.Update(bookToUpdate);

        }
        public void DeleteBook(Book bookToDelete)
        {
            if (bookToDelete == null)
            {
                throw new ArgumentNullException();
            }
            _context.Books.Remove(bookToDelete);

        }

        public Book MappingModelToDB(Book bookFromDB, Book bookToUpdate)
        {
            bookFromDB.title = bookToUpdate.title;
            bookFromDB.description = bookToUpdate.description;
            bookFromDB.author = bookToUpdate.author;
            bookFromDB.coverImage = bookToUpdate.coverImage;
            bookFromDB.price = bookToUpdate.price;
            return bookFromDB;

        }

        public void SaveChanges()
        {
             _context.SaveChanges();
        }
    }
}
