// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace MovieRental
{
    public class Movie
    {
        private string title;

        public Movie(string title)
        {
            this.title = title;

        }

        public string getTitle()
        {
            return title;
        }

        public override string ToString()
        {
            return title;
        }
    }
}