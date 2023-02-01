using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieDate { get; set; }
        public double MovieCollection { get; set; }
        public string MovieLanguage{ get; set; }
        public TimeSpan MovieDuration { get; set; }
        public int DirectorId { get; set; }

        public override string ToString()
        {
            return $"{MovieId}   {MovieName}   {MovieDate}   {MovieCollection}   {MovieLanguage}   {MovieDuration}   {DirectorId}";
        }
    }
}
