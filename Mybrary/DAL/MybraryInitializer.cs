using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mybrary.Models;

namespace Mybrary.DAL
{
    public class MybraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var book = new List<Book>
            {
            new Book{Title="Crime and Punishment", Author="Fyodor Dostoyevsky", PublishDate=1865},
            new Book{Title="1984", Author="George Orwell", PublishDate=1948},
            new Book{Title="The Brother's Karamazov",Author="Fyodor Dostoyevsky", PublishDate=1880},
            new Book{Title="A Clockwork Orange",Author="Anthony Burgess", PublishDate=1955},
            new Book{Title="the Stranger",Author="Albert Camus", PublishDate=1923},
            new Book{Title="Candid",Author="Voltaire", PublishDate=1767},
            new Book{Title="Macbeth",Author="Shakespeare", PublishDate=1645}
            };

            book.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

           
        }
    }
}