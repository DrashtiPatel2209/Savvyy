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
        void UpdateBook(Book bookToUpdate);

        void DeleteBook(Book bookToDelete);

        // Mapping from Viewmodel to Entity, It should be from Automapper. But its manual. 
        /// <summary>
        /// /
        /// </summary>
        /// <param name="bookFromDB"></param>
        /// <param name="bookToUpdate"></param>
        /// <returns></returns>
        Book MappingModelToDB(Book bookFromDB, Book bookToUpdate);
      
    }
}
