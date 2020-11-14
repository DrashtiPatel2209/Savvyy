using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SavvyyAssignment.Models;

namespace SavvyyAssignment.Data
{
    public class BookRepository : IBookRepo
    {
        private List<Book> _listOfBooks;

        public BookRepository() {
            _listOfBooks = new List<Book> {
                 new Book
            {
                id = 1,
                title = "The monk who sold his ferrari",
                author = "Robin Sharma",
                description = "The monk who sold his ferrari",
                coverImage = "Demo.png",
                price = 15.00
            },
                  new Book
            {
                id = 2,
                title = "The Power Of Now",
                author = "Eckhart Tolle",
                description = "The Power Of Now",
                coverImage = "Demo.png",
                price = 12.00
            }
          };
        }


        public IEnumerable<Book> GetBooks()
        {
            return _listOfBooks;
        }

        public Book GetBook(int id)
        {
            return _listOfBooks.Where(n => n.id == id).SingleOrDefault();
        }

        public void CreateBook(Book bookToInsert)
        {
            _listOfBooks.Add(bookToInsert);
          
        }
        public void UpdateBook(Book bookToUpdate)
        {
           ///Nothing

        }

        public void DeleteBook(Book bookToDelete)
        {
            ///Nothing

        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Book MappingModelToDB(Book bookFromDB,Book bookToUpdate)
        {
         return bookFromDB;

        }
    }
}
