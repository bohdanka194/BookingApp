using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookingApp.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Origin", Author = "Dan Brown", Year = 2017 });
            db.Books.Add(new Book { Name = "Kobzar", Author = "Taras Shevchenko", Year = 1860 });
            db.Books.Add(new Book { Name = "CLR via C#", Author = "Jeffrey Richter", Year = 2013});

            base.Seed(db);
        }
    }
}