using DelegatePart2.Models;
using System;

namespace C_Shrap_Delegate_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name, authorname;
            int pageCount, bookLimit;

            int select = GetMetodInt("Choose one of them: \n" +
                "1. Add book \n" +
                "2. Get book by id \n" +
                "3. Get all books \n" +
                "4. Delete book by id \n" +
                "5. Edit book name \n" +
                "6. Filter by page count \n" +
                "0. Quit");
            do
            {

                switch (select)
                {
                    case 1:
                        static void getAd(string name, string authorname, int pagecount)
                        {

                            name = GetMetodString("Enter the book name: ");
                            authorname = GetMetodString("Enter the author name: ");
                            pagecount = GetMetodInt("Enter the page count:");




                            Book book = new Book(name, authorname, pagecount);

                        }
                        break;



                    default:
                        break;
                }



            } while (select < 0 || select >= 6);
        }

        

        static string GetMetodString(string desc, int min = int.MinValue, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.Write(desc);
                input = Console.ReadLine();

            } while (input.Length < min || input.Length > max);
            return input;
        }

        static int GetMetodInt(string desc, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(desc);
                input = int.Parse(Console.ReadLine());

            } while (input <= min || input > max);
            return input;
        }

    }
}