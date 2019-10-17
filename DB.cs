using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingsDB
{
    public static class DB
    {
        private static MovieRatingsEntities myDB = new MovieRatingsEntities();
        public static IEnumerable<Movie> GetMovies()
        {
            return myDB.Movies.ToList();
        }

        public static Movie GetMovie(int id)
        {
            return myDB.Movies.Find(id);
        }
        public static IEnumerable<Rating> GetRatings()
        {
            return myDB.Ratings.ToList();
        }

        public static Rating GetRating(int id)
        {
            return myDB.Ratings.Find(id);
        }

    }
}
