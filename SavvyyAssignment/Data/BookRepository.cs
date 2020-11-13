using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SavvyyAssignment.Models;

namespace SavvyyAssignment.Data
{
    public class BookRepository : IBookRepo
    {
     
        public IEnumerable<Book> GetBooks()
        {
            var Books = new List<Book> {
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
            return Books;
        }

        public Book GetBook(int id)
        {
            return new Book
            {
                id = 1,
                title = "The monk who sold his ferrari",
                author = "Robin Sharma",
                description = "The monk who sold his ferrari",
                coverImage = "Demo.png",
                price = 15.00
            };
        }
    }
}
