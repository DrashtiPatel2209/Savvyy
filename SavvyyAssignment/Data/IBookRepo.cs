using SavvyyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavvyyAssignment.Data
{
    public interface IBookRepo
    {
        void SaveChanges();
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void CreateBook(Book bookToInsert);
       ///; Book UpdateBook(int id,Book bookToUpdate);
    }
}
