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

        //Get All Books
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        //Get specified book 
        public Book GetBook(int id)
        {
            return _context.Books.Where(n => n.id == id).FirstOrDefault();
        }

        /// <summary>
        /// //Inser a new book to Database
        /// </summary>
        /// <param name="bookToInsert"></param>
        public void CreateBook(Book bookToInsert)
        {
            if(bookToInsert == null) { 
                throw new ArgumentNullException();
            } 
            _context.Books.Add(bookToInsert);

        }

        // Update Book
        public void UpdateBook(Book bookToUpdate)
        {
            if (bookToUpdate == null)
            {
                throw new ArgumentNullException();
            }
            _context.Books.Update(bookToUpdate);

        }

        // Delete a book
        public void DeleteBook(Book bookToDelete)
        {
            if (bookToDelete == null)
            {
                throw new ArgumentNullException();
            }
            _context.Books.Remove(bookToDelete);

        }

        // Mapping a ViewModel to Database Entity manually
        public Book MappingModelToDB(Book bookFromDB, Book bookViewModel)
        {
            bookFromDB.title = bookViewModel.title;
            bookFromDB.description = bookViewModel.description;
            bookFromDB.author = bookViewModel.author;
            bookFromDB.coverImage = bookViewModel.coverImage;
            bookFromDB.price = bookViewModel.price;
            return bookFromDB;

        }

        public void SaveChanges()
        {
             _context.SaveChanges();
        }
    }
}
