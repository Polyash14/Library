using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class PublishingHouse
    {
        private string _country ;
        private string _nameHouse ;
        private long _amountBooks  ;
        private long _amountAuthors;
        private int _startYear ;

        public string NameHouse { get => _nameHouse; set => _nameHouse = value; }
        public long AmountBook { get => _amountBooks; set => _amountBooks = value; }
        public long AmountAuthors { get => _amountAuthors; set => _amountAuthors = value; }
        public int StartYear { get => _startYear; set => _startYear = value; }
        public string Country { get => _country; set => _country = value; }

        public PublishingHouse(string nameHouse)
        {
            NameHouse = nameHouse;
        }

        public PublishingHouse( long amountBook, long amountAuthor)
        {
            AmountAuthors = amountAuthor;
            AmountAuthors = amountBook;
        }

        public PublishingHouse( int startYear, string country)
        {
            StartYear = startYear;
            Country = country;
        }

        public override string ToString()
        {
            return $"Publishing House owner - {Country}";
        }
    }
}
