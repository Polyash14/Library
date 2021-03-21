using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string nameAuthor = "Zak Cody";
            string nameBook = "Trust";
            string publishingHouse = "home";
            string country = "Italia";
            int startYear = 2000;
            string name = "Trust";
            string genre = "Fantasy";

            Author author = new Author(nameAuthor, publishingHouse, nameBook);

            PublishingHouse publishing = new PublishingHouse(startYear, country);

            BOOK book = new BOOK(genre, name);

            Console.WriteLine(publishing.ToString());

            Console.WriteLine(author.ToString());

            Console.WriteLine(book.ToString());
        }

        
    }
}
