using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SavvyyAssignment.Models;

namespace SavvyyAssignment.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> opt) : base(opt)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
