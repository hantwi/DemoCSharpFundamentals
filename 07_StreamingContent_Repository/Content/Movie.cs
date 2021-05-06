using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository.Content
{
    public class Movie : StreamingContent
    {
        public Movie() { }
        public Movie(string title, string description, double stars, GenreType genreType, MaturityRating maturityRating, double runTime) : base(title,description, stars, genreType, maturityRating)
        {
            // Setting properties that aren't included in base constructor
            RunTime = runTime;
        }
            public double RunTime { get; set; }
    }
}
