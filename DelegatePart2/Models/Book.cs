using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePart2.Models
{
    internal class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName{ get; set; }
        public int PageCount { get; set; }

        public Book(string name, string author, int pgcnt)
        {
            Name = name;    
            AuthorName = author;
            PageCount = pgcnt;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Book name: {Name}\n" +
                $"Author: {AuthorName}\n" +
                $"Page count: {PageCount}\n" +
                $"");
        }
        public bool IsDeleted(Book book)
        {
            bool result = false;

            if (book == null)
            {
                result = true;
            }

            return result;
        }
    }
}