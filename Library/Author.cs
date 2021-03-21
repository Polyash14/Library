using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Author
    {
        private long _birthDate;
        private int _amountBook;
        private string _nameBook;
        private string _nameAuthor ;
        private string _publishingHouse;

        public string NameAuthor { get => _nameAuthor; set => _nameAuthor = value; }
        public string PublishingHouse { get => _publishingHouse; set => _publishingHouse = value; }
        public string NameBook { get => _nameBook; set => _nameBook = value; }
        public long BirthDate { get => _birthDate; set => _birthDate = value; }
        public int AmountBook { get => _amountBook; set => _amountBook = value; }

        public Author(string nameAuthor, string publishingHouse, string nameBook)
        {
            NameAuthor = nameAuthor;
            PublishingHouse = publishingHouse;
            NameBook = nameBook ;
        }

        public Author (long birtDate)
        {
            BirthDate = birtDate;
           
        }

        public Author(int amountBook)
        {
            AmountBook = amountBook;
        }
       
           

        public override string ToString()
        {
            return $"Book - {NameBook}; Author - {NameAuthor}; Publishing House name - {PublishingHouse}";
        }
    }
}
