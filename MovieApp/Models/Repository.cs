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
                      Description="<p>The objective of this technique is to provide a long text alternative that serves the same purpose and presents the same information as the original non-text content when a short text alternative is not sufficient.Combined with the short text alternative, the long description should be able to substitute for the non-text content.The short alternative identifies the non - text content; the long alternative provides the information.If the non - text content were removed from the page and substituted with the short and long descriptions, the page would still provide the same function and information.</p>",
                      ImageUrl ="1.png",
                       ShortDescription="d1"
                },
                new Movie()
                {
                     Id=2,
                      Name="bbbb",
                      Description="<p>The objective of this technique is to provide a long text alternative that serves the same purpose and presents the same information as the original non-text content when a short text alternative is not sufficient.Combined with the short text alternative, the long description should be able to substitute for the non-text content.The short alternative identifies the non - text content; the long alternative provides the information.If the non - text content were removed from the page and substituted with the short and long descriptions, the page would still provide the same function and information.</p>",
                      ImageUrl ="2.png",
                       ShortDescription="d2"
                },
                new Movie()
                {
                     Id=2,
                      Name="cccc",
                      Description="<p>The objective of this technique is to provide a long text alternative that serves the same purpose and presents the same information as the original non-text content when a short text alternative is not sufficient.Combined with the short text alternative, the long description should be able to substitute for the non-text content.The short alternative identifies the non - text content; the long alternative provides the information.If the non - text content were removed from the page and substituted with the short and long descriptions, the page would still provide the same function and information.</p>",
                      ImageUrl ="3.png",
                       ShortDescription="d3"
                },
                new Movie()
                {
                     Id=3,
                      Name="dddd",
                      Description="<p>The objective of this technique is to provide a long text alternative that serves the same purpose and presents the same information as the original non-text content when a short text alternative is not sufficient.Combined with the short text alternative, the long description should be able to substitute for the non-text content.The short alternative identifies the non - text content; the long alternative provides the information.If the non - text content were removed from the page and substituted with the short and long descriptions, the page would still provide the same function and information.</p>",
                      ImageUrl ="4.png",
                       ShortDescription="d4"
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
