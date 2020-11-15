using System;
using System.Collections.Generic;
using SavvyyAssignment.Models;
using SavvyyAssignment.Controllers;
using System.Text;
using System.Linq;
using SavvyyAssignment.Data;

namespace WebAPITest
{
    class BookRepoTest : IBookRepo
    {
        private readonly List<Book> _books;
        public BookRepoTest()
        {
            _books = new List<Book>()
            {
                new Book() { id = 1, title = "The Monk Who Sold Hid ferrari",
                    description ="The Monk Who Sold Hid ferrari", price = 5.00, author = "Robin Sharma", coverImage = "C:/Demo.png"  },
                new Book() {id = 2, title = "The 5 AM club",
                    description ="The 5 AM club", price = 5.00, author = "Robin Sharma", coverImage = "C:/Demo.png"  },
                new Book() { id = 3, title = "The Secret",
                    description ="The Secret", price = 5.00, author = "Robin Sharma", coverImage = "C:/Demo.png" }
            };
        }
        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }
        public void CreateBook(Book newItem)
        {
            newItem.id = 0;
            _books.Add(newItem);
           
        }
        public Book GetBook(int id)
        {
            return _books.Where(a => a.id == id)
                .FirstOrDefault();
        }
        public void UpdateBook(Book bookToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            var existing = _books.First(a => a.id == book.id);
            _books.Remove(existing);
        }
        
        public void SaveChanges()
        {
           //
        }
         public Book MappingModelToDB(Book bookFromDB, Book bookToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
