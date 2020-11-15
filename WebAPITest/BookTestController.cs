using System;
using System.Collections.Generic;
using System.Text;
using SavvyyAssignment.Models;
using SavvyyAssignment.Controllers;
using SavvyyAssignment.Data;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest
{
    public class BookTestController
    {
        BooksController _controller;
        IBookRepo _bookRepo;
        public BookTestController()
        {
            _bookRepo = new BookRepoTest();
            _controller = new BooksController(_bookRepo);
        }

     
        [Fact]
        public void Get_AllBooks()
        {
            // Act
            var okResult = _controller.GetBooks().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        [Fact]
        public void GetById_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.GetBookById(100);
            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }
        [Fact]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {
          
            // Act
            var okResult = _controller.GetBookById(1);
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsRightItem()
        {
            // Arrange
            var idToTest = 1 ;
            // Act
            var okResult = _controller.GetBookById(idToTest).Result as OkObjectResult;
            // Assert
            Assert.IsType<Book>(okResult.Value);
            Assert.Equal(idToTest, (okResult.Value as Book).id);
        }

        [Fact]
        public void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            // Arrange
            var authorMissingItem = new Book()
            {
                title = "ToTest",
                price = 12
            };
            _controller.ModelState.AddModelError("Author", "Required");
            // Act
            var badResponse = _controller.CreateBook(authorMissingItem);
            // Assert
            Assert.IsNotType<CreatedResult>(badResponse);
        }
        [Fact]
        public void Remove_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            // Arrange
            var notExistingId = 150;
            // Act
            var badResponse = _controller.DeleteBook(notExistingId);
            // Assert
            Assert.IsType<NotFoundResult>(badResponse);
        }
        [Fact]
        public void Remove_ExistingIdPassed_ReturnsOkResult()
        {
            // Arrange
            var existingGuid = 1;
            // Act
            var okResponse = _controller.DeleteBook(existingGuid);
            // Assert
            Assert.IsType<NoContentResult>(okResponse);
        }
    }
}
