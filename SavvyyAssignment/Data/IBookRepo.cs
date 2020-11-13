using SavvyyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavvyyAssignment.Data
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
    }
}
