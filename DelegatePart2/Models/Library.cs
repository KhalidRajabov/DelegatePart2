using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePart2.Models
{
    internal class Library:IEntity
    {
        public int BookLimit { get; set; }
        Book [] Books = new Book [0];

        public void AddBook(Book books)
        {
            foreach (Book item in Books)
            {
                if (books.Name != item.Name && item.IsDeleted(item) == false && Books.Length <= BookLimit)
                {
                    Array.Resize(ref Books, Books.Length + 1);
                    Books[Books.Length - 1] = books;
                }
            }
        }

        public void GetBookById(int? id)
        {
            foreach (Book item in Books)
            {
                if (item.Id == id && item.IsDeleted(item) == false)
                {
                    item.ShowInfo();
                }
                else if (id == null)
                {
                    throw new NullReferenceException("Id is null");
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }

        internal static void AddBook(object book)
        {
            throw new NotImplementedException();
        }

        public void GetAllBooks()
        {
            Book[] books = new Book[Books.Length];
            for (int i = 0; i < Books.Length; i++)
            {
                books[i] = Books[i];
            }
            foreach (var item in books)
            {
                item.ShowInfo();
            }
        }

        public void DeleteBookById(int? id)
        {
            foreach (Book item in Books)
            {
                if (item.Id == id && item.IsDeleted(item) == false)
                {
                    Array.Resize(ref Books, Books.Length - 1);
                    Books[Books.Length] = item;
                }
            }
        }

        public void EditBookName(int? id)
        {
            foreach (Book item in Books)
            {
                if (item.Id == id)
                {
                    Console.Write("Change name: ");
                    string name = Console.ReadLine();
                    item.Name = name;
                }
            }
        }

        public void FilterByPageCount(int minPage, int maxPage)
        {
            foreach (Book item in Books)
            {
                if (item.IsDeleted(item) == false && item.PageCount == minPage || item.PageCount == maxPage)
                {
                    item.ShowInfo();
                }
            }
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}