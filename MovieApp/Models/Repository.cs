using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                     Id=1,
                      Name="sss",
                      Description="d1",
                      ImageUrl ="1.png"
                },
                new Movie()
                {
                     Id=2,
                      Name="bbbb",
                      Description="d2",
                      ImageUrl ="2.png"
                },
                new Movie()
                {
                     Id=2,
                      Name="cccc",
                      Description="d3",
                      ImageUrl ="3.png"
                },
                new Movie()
                {
                     Id=3,
                      Name="dddd",
                      Description="d4",
                      ImageUrl ="4.png"
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
