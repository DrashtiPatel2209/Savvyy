using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SavvyyAssignment.Models;
using SavvyyAssignment.Data;

namespace SavvyyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _bookRepository;

        public BooksController(IBookRepo bookRepository) {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks() {

            var books = _bookRepository.GetBooks();
            if (books != null && books.Count() >= 0) {
                return Ok(books);
            }
            return NotFound(); 
        }

        [HttpGet("{id}", Name="GetBookById")]
        public ActionResult<Book> GetBookById(int id)
        {

            var book = _bookRepository.GetBook(id);
            if (book != null) {
                return Ok(book);
            }
             return NotFound();
        }
        [HttpPost]
        public ActionResult<Book> CreateBook(Book bookToInsert)
        {

            _bookRepository.CreateBook(bookToInsert);
            _bookRepository.SaveChanges();
            ///return CreatedAtAction(nameof(Book), new { id = insertedBook.id }, insertedBook);
            return CreatedAtRoute(nameof(GetBookById),new { id = bookToInsert.id}, bookToInsert);
        }

        //[HttpPut]
        //public ActionResult<Book> UpdateBook(int id, Book bookToUpdate)
        //{

        //    Book updateBook = _bookRepository.GetBook(id);
        //    if (bookToUpdate != null)
        //    {
        //        return Ok(bookToUpdate);
        //    }
        //    ///return CreatedAtAction(nameof(Book), new { id = insertedBook.id }, insertedBook);
        //    return NotFound();
        //}

    }
}