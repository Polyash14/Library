using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class BOOK
    {
        private Author _author;
        private PublishingHouse _publishingHouse;
        private string _genre;
        private int _page;
        private string _name;

        public string Genre { get => _genre; set => _genre = value; }
        public int Page { get => _page; set => _page = value; }
        public string Name { get => _name; set => _name = value; }

        public BOOK(string genre, string name)
        {
            Genre = genre;
            Name = name;
        }

        public BOOK(int page)
        {
            Page = page;
        }

        public override string ToString()
        {
            return $"Book - {Name}, genre book - {Genre}";
        }
    }
}
